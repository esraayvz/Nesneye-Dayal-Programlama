﻿using EscapeLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeLibrary.Concrete
{
    internal class Block : Obj
    {
        public Block(int yukseklik, Size moveAreaSize) : base(moveAreaSize)
        {
            
        }
    }
}
// Obj sınıfından türetilmiş özel bir sınıftır.
// Kurucu metodunda yükseklik bilgisini alır.
// moveAreaSize parametresiyle üst sınıfın kurucusunu çağırarak özelliklerini belirtilen boyuta göre ayarlar.
