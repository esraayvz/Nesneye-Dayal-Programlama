using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscapeLibrary.Concrete;
using EscapeLibrary.Enum;

namespace EscapeGame
{
    public partial class Level1 : Form
    {
        // B211200045 Esra Ayvaz

        private readonly Game _game;

        
        public Level1()
        {
            // Formun başlangıç boyutu ve ön plana çıkma durumu ayarlanır
            InitializeComponent();
            this.Size = new Size(1050, 450);
            labelTime.BringToFront();

            // Oyunun temel işlevselliğini yöneten Game sınıfından bir örnek oluşturulur
            _game = new Game(panelMain, panelInfo, levelLabel, labelHealt, labelScore, labelPlayer, textPlayer, menuPanel, isCont);

            // Oyundaki ElapsedTimeChanged etkinliğine abone olunur
            _game.ElapsedTimeChanged += Game_ElapsedTimeChanged;
        }

        // Klavye tuşlarına basıldığında oyun kontrollerini sağlar.
        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _game.Start();
                    break;
                case Keys.Right:
                    _game.Move(Direction.right);
                    break;
                case Keys.Left:
                    _game.Move(Direction.left);
                    break;
                case Keys.Up:
                    _game.Move(Direction.up);
                    break;
                case Keys.Down:
                    _game.Move(Direction.down);
                    break;
                case Keys.P:
                    _game.Pause();
                    break;
            }
        }

        private void Game_ElapsedTimeChanged(object sender, EventArgs e)
        {
            // ElapsedTimeChanged etkinliği tetiklendiğinde süreyi günceller
            labelTime.Text = _game.ElapsedTime.ToString(@"m\:ss");
        }

        // Form yüklendiğinde KeyPreview özelliği true olarak ayarlanır
        private void Level1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

    }
}