using EscapeLibrary.Enum;
using EscapeLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace EscapeLibrary.Concrete
{
    public class Game : IGame
    {
        // B211200045 Esra Ayvaz.

       

        private Random random = new Random();
        #region Timers

        private readonly Timer _elapsedTimer = new Timer { Interval = 1000 };

        private readonly Timer _createBombTimer = new Timer { Interval = 3000 };
        private readonly Timer _restoreBlockTimer = new Timer { Interval = 6000 };

        private readonly Timer _createMinionTimer = new Timer { Interval = 2000 };
        private readonly Timer _moveMinionTimer = new Timer { Interval = 1000 };

        #endregion

        #region Properties

        public bool IsContinue { get; private set; }


        public int _level = 1;
        public int _healt = 3;
        public int _score = 0;
        public int healt { // Healt değeri, metodlarda azaltıldığında bu property' nin set özelliği çalışacak ve dinamik bir healt değişimi yapılacak.
            get => _healt;
            set { _healt = value; }
        }

        public int score 
        {   get => _score;
            set
            {
                _score = value;
            }
        }

        #endregion

        #region Fields

        private readonly Panel _panelMain;
        private readonly Panel _panelInfo;
        private readonly Panel _panelMenu;

        private Label _levelLabel;
        private Label _healtLabel;
        private Label _scoreLabel;
        private Label _playerLabel;
        private Label _contLabel;

        private TextBox _playerText;

        private Hero _hero;

        private Block[] _blocks = new Block[50];
        private readonly List<Minion> _minions = new List<Minion>();
        #endregion

        #region EventHandlers
        public event EventHandler BombTimeChanged;
        public event EventHandler MinionTimeChanged;

        public event EventHandler RestoreMinionChanged;
        public event EventHandler RestoreBlockChanged;
 
        public event EventHandler ElapsedTimeChanged;
        #endregion

        #region TimeSpans

        private TimeSpan _elapsedTime;      
        public TimeSpan ElapsedTime 
        {   get => _elapsedTime;
            private set
            {
                _elapsedTime = value;
                ElapsedTimeChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        #endregion
        public Game(Panel panelmain, Panel panelinfo, Label levelLabel, Label healtLabel, Label scoreLabel, Label playerLabel, TextBox playerText, Panel panelMenu, Label cont) 
        {
            // Sağlanan kontrollerle üye değişkenleri başlat

            _panelMain = panelmain;
            _panelInfo = panelinfo;
            _levelLabel = levelLabel;
            _healtLabel = healtLabel;
            _scoreLabel = scoreLabel;
            _playerLabel = playerLabel;
            _playerText = playerText;
            _panelMenu = panelMenu;
            _contLabel = cont;

            // İlgili zamanlayıcıların tick olaylarına olay işleyicilerini bağla

            _elapsedTimer.Tick += ElapsedTimer_Tick;   

            _createBombTimer.Tick += CreateBombTimer_Tick;
            _createMinionTimer.Tick += CreateMinionTimer_Tick;

            _moveMinionTimer.Tick += MoveMinionTimer_Tick;
            _restoreBlockTimer.Tick += RestoreBlockTimer_Tick;       
        }

        private void MoveMinionTimer_Tick(object sender, EventArgs e)
        {
            MoveMinion();
        }

        private void CreateMinionTimer_Tick(object sender, EventArgs e)
        {
            CreateMinion();
        }

        private void RestoreBlockTimer_Tick(object sender, EventArgs e)
        {
            RestartBlock();
        }

        private void ElapsedTimer_Tick(object sender, EventArgs e)
        {
            ElapsedTime += TimeSpan.FromSeconds(1);
            _score = _healt * 500 + (1000 - ElapsedTime.Seconds);
            _scoreLabel.Text = Convert.ToString(_score);
        }

        private void CreateBombTimer_Tick(object sender, EventArgs e)
        {
           CreateBomb();
        }

        public void Move(Direction direction)
        {
            if (!IsContinue) return;  // Eğer oyun devam etmiyorsa, hareketi gerçekleştirme
            _hero.DoMove(direction);           
            checkTrap();
            checkBomb();
            checkMinion();
            checkChest();
            checkFinish();
        }
        public void Pause()
        {
            
            IsContinue = !IsContinue;
            if (IsContinue)
            {
                // Oyunun seviyesine göre ilgili zamanlayıcıları başlat
                switch (_level)
                {
                    case 1 :
                        _elapsedTimer.Start();
                        break;
                    case 2:
                        
                        startTimers(_createBombTimer, _restoreBlockTimer);
                        break;
                    case 3:
                        
                        startTimers(_createMinionTimer, _moveMinionTimer);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                StopTimers(); // Oyun duraklatıldığında tüm zamanlayıcıları durdur
            }
        }
        public void Start()
        {
            IsContinue = true; // Oyunu başlat
            PlayerMenu();

            // Zamanlayıcıyı başlat ve oyun nesnelerini oluştur

            _elapsedTimer.Start(); 
            createHero();
            createBlock();
            createChest();
            createTrap();
        }

        private void PlayerMenu()
        {
            // Oyuncu adını menü etiketine ayarla

            _playerLabel.Text = Convert.ToString(_playerText.Text); 
            _panelMenu.Visible = false;
        }

        private void createHero()
        {
            _hero = new Hero(_panelMain.Height, _panelMain.Size)
            {

            };
            _hero.Size = new Size(100, 100);
            _hero.MaximumSize = new Size(100, 100);
            _hero.MinimumSize = new Size(100, 100);
            _hero.SizeMode = PictureBoxSizeMode.StretchImage;
            _hero.BackColor = Color.Transparent;
            _panelMain.Controls.Add(_hero); // Hero nesnesini ana panel içine ekleyip en üste getir
            _hero.BringToFront();
        }     
        protected void createBlock()
        {
            // Blok oluşturulacak başlangıç koordinatları ve boyutları

            int startX = 0;
            int startY = 0;

            int width = 150;
            int height = 150;

            int chest = random.Next(2, 50);
            double randomValue = random.NextDouble();

           
            int result = (randomValue < 0.8) ? 1 : 2;        

            for (int i = 0; i < 50; i++) 
            {                      
                _blocks[i] = new Block(_panelMain.Height, _panelMain.Size)   // Her bir bloğun özelliklerini ayarla
                {
                    Name = "Block" + (i + 1),
                    Size = new Size(150, 150),
                    Location = new Point(startX, startY)
                };
                _blocks[i].SendToBack();
                _blocks[i].Click += Block_click;

                // Başlangıç ve bitiş bloklarını özel olarak işaretle

                if (i == 0)
                {
                    _blocks[i].Name = "StartBlock";
                    _blocks[i].Size = new Size(150, 150);
                    _blocks[i].Location = new Point(startX, startY);
                    _blocks[i].Click += Block_click;
                }

                if (i == 47)
                {
                    _blocks[i].Name = "Finish";
                    _blocks[i].Size = new Size(150, 150);
                    _blocks[i].Location = new Point(startX, startY);
                    _blocks[i].Click += Block_click;
                    _blocks[i].Image = Image.FromFile(@"img\Finish.png");
                }
                _panelMain.Controls.Add(_blocks[i]); // Bloğu ana panele ekle

                // Yeni bloğun konumunu güncelle
                startY += height; 
                if (startY + height > _panelMain.Height)
                {
                    startY = 0;
                    startX += width;
                }
            }
        }       
        private void createChest()
        {
            // Rastgele bir blok seç ve eğer uygunsa, onu bir sandık haline getir

            while (true)
            {
                int number = random.Next(2, 50);
                if (number != 47 && _blocks[number].Name.StartsWith("Block"))
                {
                    _blocks[number].Name = "Chest";
                    _blocks[number].Image = Image.FromFile(@"img\Chest.png");
                }
                break;
            }          
        }
        Random rnd = new Random();
        public List<int> availableNumbers = Enumerable.Range(1, 50).ToList();

        public void createTrap() 
        {
            // Rastgele seçilen 10 bloğu tuzak olarak işaretle

            var randomBlocks = _blocks.OrderBy(x => random.Next()).Take(10).ToList();
            foreach (var block in randomBlocks)
            {
                if (block.Name != "Finish" && block.Name != "StartBlock" && block.Name.Contains("Block"))
                {
                    // Bloğun adını tuzak olarak değiştir
                    int blockIndex = Array.IndexOf(_blocks, block);
                    block.Name = $"Trap{blockIndex:D2}";

                }
            }
            
        }
        protected void CreateBomb()
        {
            // Blokları başlangıç durumuna getir ve rastgele seçilen 10 bloğu bomba olarak işaretle

            RestartBlock();
            var randomBlocks = _blocks.OrderBy(x => random.Next()).Take(10).ToList();
            
            foreach (var block in randomBlocks)
            {
                if (block.Name != "Finish" && block.Name != "StartBlock" && block.Name != "Chest")
                {
                    // Bloğun adını bomba olarak değiştir ve görselini güncelle
                    int blockIndex = Array.IndexOf(_blocks, block);
                    block.Name = $"Bomb{blockIndex:D2}";
                    block.Image = Image.FromFile(@"img\Bomb.png");                   
                }                
            }
            checkBomb();  // Bombaların etrafındaki blokları kontrol et
        }
        private void CreateMinion()
        {
            // Yeni bir Minion nesnesi oluştur ve panel içine ekleyip en üste getir
            var minion = new Minion(_panelMain.Size);
            _minions.Add(minion);
            _panelMain.Controls.Add(minion);
            minion.BringToFront();
            minion.Click += Minion_click;           
        }
        
        protected void checkTrap()
        {
            // Panel içindeki her kontrolü kontrol et
            foreach (Control control in _panelMain.Controls)
            {
                // Eğer kontrol bir Blok ve adında "Trap" geçiyorsa ve kahraman ile kesişiyorsa can kaybedersin.
                if (control is Block && control.Name.Contains("Trap") && _hero.Bounds.IntersectsWith(control.Bounds)) 
                {   
                    //rastgele trap seç
                    string pcName = control.Name;
                    string lastTwo = pcName.Substring(4);
                    int a = Convert.ToInt32(lastTwo);
                    Random TrapNumber = new Random();
                    int b = TrapNumber.Next(1, 4);

                    // Seçilen Trap türüne göre Blok görüntüsünü güncelle
                    switch (b)
                    {
                        case 1:
                            _blocks[a].Image = Image.FromFile(@"img\Fire.png");
                            break;
                        case 2:
                            _blocks[a].Image = Image.FromFile(@"img\Trap.png");
                            break;
                        case 3:
                            _blocks[a].Image = Image.FromFile(@"img\Snake.png");
                            break;
                        default:
                            break;
                    }
                    LostHealt();//can kaybı
                }
            }
        }
        protected void checkBomb()
        {
            //kahraman ile kesişiyorsa can kaybı

            foreach (Control control in _panelMain.Controls)
            {
                if (control is Block && control.Name.Contains("Bomb") && _hero.Bounds.IntersectsWith(control.Bounds)) 
                {
                    LostHealt();
                }
            }
        }
        protected void checkMinion()
        {
            //kahraman ile kesişirse can kaybı
            foreach (Control control in _panelMain.Controls)
            {
                if (control is Minion && control.Name.Contains("Minion") && _hero.Bounds.IntersectsWith(control.Bounds)) 
                {
                    _hero.BringToFront();
                    LostHealt();
                    break;
                }
            }
        }
        private void checkChest()
        {
            foreach (Control control in _panelMain.Controls)
            {
                // Eğer kontrol bir Blok ve adında "Chest" geçiyorsa ve kahraman ile kesişiyorsa

                if (control is Block && control.Name.Contains("Chest") && _hero.Bounds.IntersectsWith(control.Bounds)) 
                {
                    // Sandık içeriğini rastgele belirle
                    double state = random.NextDouble();
                    int result = (state < 0.8) ? 0 : 1;
                    switch (result)
                    {
                        case 0:
                            control.Name = "GoodChest";
                            UpHealt(); //can artışı sağlar
                            control.Name = "GoodC";
                            break;
                        case 1:
                            control.Name = "BadChest";
                            LostHealt(); //can kaybına sebep olur
                            control.Name = "BadC";
                            break;
                    }
                }
            }
        }
        protected void checkFinish()
        {
            foreach (Control control in _panelMain.Controls)
            {
                // Eğer kontrol bir Blok ve adında "Finish" geçiyorsa ve kahraman ile kesişiyorsa
                if (control is Block && control.Name.Contains("Finish") && _hero.Bounds.IntersectsWith(control.Bounds)) 
                {
                    // Eğer seviye 3 ise Wp metodunu çağır
                    if (_level == 3)
                    {
                        Wp();
                    }                    
                    LevelUp();
                }
            }
        }

        private void RestartBlock()
        {
            // Bomba olan blokları başlangıç durumuna getir

            foreach (var block in _blocks)
            {
                if (block.Name.StartsWith("Bomb"))
                {
                    block.Image = Image.FromFile(@"img\Block.png");
                    block.Name = "Block" + (Array.IndexOf(_blocks, block) + 1);
                }
            }
        }     
        private void MoveMinion()
        {
            // Sola doğru hareket ettir ve panel dışına çıkanları kaldır.

            for (var i = _minions.Count - 1; i >= 0; i--)
            {
                var minion = _minions[i];
                if (minion.Location.X >= 150) 
                {
                    minion.Left -= 150;
                }
                else
                {
                    _panelMain.Controls.Remove(minion);
                }
                
            }
            checkMinion();
        }
        private void LostHealt()
        {
            _healt--; 
            if (_healt > 0)
            {          
                _healtLabel.Text = Convert.ToString(healt);
            }
            else if (_healt == 0)
            {
                //can 0 ise oyun biter ve ekrana game over yazısı gelir.
                _healtLabel.Text = Convert.ToString(healt);
                //writeScore();
                StopTimers();
                MessageBox.Show("GAME OVER !!!");             
                Application.Exit();
            }
        }
        private void UpHealt()
        {
            _healt++;
            _healtLabel.Text = Convert.ToString(healt);
        }
        protected void LevelUp()
        {
            Destroy();
            _level++;
            writeScore();
            UpHealt();
            // Seviyeye göre işlemleri gerçekleştir
            switch (_level)
            {
                case 2:
                    createBlock();
                    createHero();
                    createChest();
                    CreateBomb();
                    _createBombTimer.Start();
                    _restoreBlockTimer.Start();
                    _levelLabel.Text = Convert.ToString(_level);
                    _healtLabel.Text = Convert.ToString(healt);
                    break;
                case 3:
                    _createBombTimer.Stop();
                    _restoreBlockTimer.Stop();
                    createBlock();
                    createHero();
                    createChest();
                    CreateMinion();                   
                    _moveMinionTimer.Start();
                    _createMinionTimer.Start();
                    _levelLabel.Text = Convert.ToString(_level);
                    _healtLabel.Text = Convert.ToString(healt);
                    break;
            } 
        }
        private void writeScore()
        {
            // Skor hesapla ve Scores.txt dosyasına yaz

            _score = _healt * 500 + (1000 - ElapsedTime.Seconds);
            string s = _scoreLabel.Text = Convert.ToString(_score);          
            using (StreamWriter writer = new StreamWriter("Scores.txt",true))
            {
                writer.WriteLine($"Oyuncu -> {_playerLabel.Text} Skor ->{_score}");
            }
        }
        private void Destroy()
        {
            // Oyuncu nesnesini ve blokları temizle

            _panelMain.Controls.Remove(_hero);
            BlockRemove();
        }       
        private void BlockRemove()
        {
            for (int i = 0; i < 50; i++)
            {             
                if (_blocks[i].Name.Contains("Trap"))
                {
                    _panelMain.Controls.Remove(_blocks[i]);
                }
                _panelMain.Controls.Remove(_blocks[i]);
            }
        }
        private void Block_click(object sender, EventArgs e)
        {
            Block clicked = (Block)sender;
            MessageBox.Show(clicked.Name + " Clicked!"); 
        }
        private void Minion_click(object sender, EventArgs e)
        {
            Minion clicked = (Minion)sender;
            MessageBox.Show(clicked.Name + " Clicked!"); 
        }
        private void Wp()
        {
            //oyun bittiğinde zamanlayıcıları durdur.
            writeScore();
            StopTimers();
            MessageBox.Show("OYUN BİTTİ !!!", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);           
            Application.Exit(); 
        }
        private void StopTimers()
        {
            //zamanlayıcıları durdur
            _elapsedTimer.Stop();
            _createBombTimer.Stop();
            _restoreBlockTimer.Stop();
            _createMinionTimer.Stop();
            _moveMinionTimer.Stop();
        }
        //zamanlayıcıları başlatma
        protected void startTimers(params Timer[] _timer  )
        {
            _elapsedTimer.Start();
            foreach ( Timer timer in _timer )
            {
                timer.Start();
            }
        }
        private void lvl2TimerStart()
        {
            _elapsedTimer.Start();
            _createBombTimer.Start();
            _restoreBlockTimer.Start();          
        }
        private void lvl3TimerStart()
        {
            _createMinionTimer.Start();
            _moveMinionTimer.Start();
        }
    }
}
