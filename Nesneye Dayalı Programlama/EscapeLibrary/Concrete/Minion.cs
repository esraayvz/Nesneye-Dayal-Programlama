using EscapeLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeLibrary.Concrete
{
    internal class Minion : Obj
    {
        // B221200305 Esra Ayvaz 

        public Minion(Size moveAreaSize) : base(moveAreaSize)
        {
            Random random = new Random();
            EMoveDistance = 150; //hareket mesafesi kontrolü
           
            int x = random.Next(6, 9) * 150 ; //nesnesinin yatay konumunu belirlemek için rastgele bir X koordinatı oluşturulur.
            int y = random.Next(1, 5) * 150;  //nesnesinin dikey konumunu belirlemek için rastgele bir Y koordinatı oluşturulur.
            Name = "Minion";
            Size = new Size(150, 150);
            SizeMode = PictureBoxSizeMode.StretchImage;
            Location = new Point(x, y);
            
        }
    }
}
