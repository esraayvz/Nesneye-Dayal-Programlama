using EscapeLibrary.Enum;
using EscapeLibrary.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

//B211200045 Esra Ayvaz

namespace EscapeLibrary.Abstract
{
    // Obj sınıfı, PictureBox sınıfını genişleten ve IMove arabirimini uygulayan soyut bir sınıftır.
    internal abstract class Obj : PictureBox, IMove
    {
        public Size MoveAreaSize { get; } // MoveAreaSize özelliği, hareket alanının boyutunu temsil eder.

        public int HMoveDistance { get; protected set; }// HMoveDistance özelliği, yatay hareket mesafesini temsil eder.
        public int EMoveDistance { get; protected set; }// EMoveDistance özelliği, dikey hareket mesafesini temsil eder.
        public new int Right // Özel set uygulamasına sahip Right özelliği.
        {
            get => base.Right;
            set => Left = value - Width; // Right değerine dayalı olarak Width'i korumak için Left özelliğini ayarlar.

        }
        public new int Bottom // Özel set uygulamasına sahip Bottom özelliği.
        {
            get => base.Bottom;
            set => Top = value - Height; // Bottom değerine dayalı olarak Height'i korumak için Top özelliğini ayarlar.
        }
    

        public int Center // Center özelliği, nesnenin yatay orta noktasını temsil eder.
        {
            get => Left + (Width / 2);
            set => Left = value - (Width / 2); // Yatay orta değerine dayalı olarak nesneyi konumlandırmak için Left özelliğini ayarlar.
        }
    

        public int Middle // Middle özelliği, nesnenin dikey orta noktasını temsil eder.
        {
            get => Top + (Height / 2);
            set => Top = value - (Height / 2); // Dikey orta değerine dayalı olarak nesneyi konumlandırmak için Top özelliğini ayarlar.
        }
        
        protected Obj(Size moveAreaSize)
        {
            Image = Image.FromFile($@"img\{GetType().Name}.png"); // Nesnenin görüntüsü, sınıfın adına göre belirtilen yol üzerinden yüklenir.
            MoveAreaSize = moveAreaSize; 
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public bool DoMove(Direction direction)
        {
            // Yöne göre hareket etmeyi sağlayan metod çağrılır.

            switch (direction)
            {
                case Direction.left:
                    return MoveLeft();
                case Direction.right:
                    return MoveRight();
                case Direction.up:
                    return MoveUp();
                case Direction.down:
                    return MoveDown();
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        private bool MoveDown()
        {
            if (Bottom == MoveAreaSize.Width - 25) return true;  // Alt kenarın hareket alanının genişliğine yakın olduğu durumda true döndürülür.

            var newBottom = Bottom + HMoveDistance;    // Yeni alt kenar hesaplanır.
            var isOver = newBottom > MoveAreaSize.Height - 25;

            Bottom = isOver ? MoveAreaSize.Height - 25 : newBottom; 

            return Bottom == MoveAreaSize.Height - 25;
        }

        private bool MoveUp()
        {
            if (Top == 25) return true; 
                                       
            var newTop = Top - HMoveDistance; 
            var isOver = newTop < 25;  // Yeni üst kenar, 25 birimden daha küçükse isOver true olur.
            Top = isOver ? 25 : newTop; 

            return Top == 25;
        }

        private bool MoveRight()
        {
            if (Right == MoveAreaSize.Width - 25) return true;

            var newRight = Right + HMoveDistance; 
            var isOver = newRight > MoveAreaSize.Width - 25;

            Right = isOver ? MoveAreaSize.Width - 25 : newRight; // Eğer taşma durumu varsa sağ kenar hareket alanının genişliğinden 25 birim çıkartılarak ayarlanır.

            return Right == MoveAreaSize.Width - 25;
        }

        private bool MoveLeft()
        {
            if (Left == 25) return true; 
                                         
            var newLeft = Left - HMoveDistance; 
            var isOver = newLeft < 25;
            Left = isOver ? 25 : newLeft; 

            return Left == 25; // Sol kenarın 25 birime yakın olduğu durumu döndürür.
        }
    }
}

