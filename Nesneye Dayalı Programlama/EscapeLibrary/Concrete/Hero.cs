using System;
using System.Drawing;
using EscapeLibrary.Abstract;

namespace EscapeLibrary.Concrete
{
    internal class Hero : Obj
    {
        
        public Hero(int yukseklik, Size moveAreaSize) : base (moveAreaSize)
        {
            //başlanılan konum ile tek harekette kaç adım gideceği
            Left = 25; 
            Top = 25;          
            HMoveDistance = 150;
            

        }
    }
}
