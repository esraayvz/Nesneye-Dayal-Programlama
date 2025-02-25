using EscapeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeLibrary.Interface
{
    internal interface IMove
    {
        // Setter uygulanmamıştır, dışarıdan hareket alanının değiştirilmesini önlemek içindir.
        Size MoveAreaSize { get; }

        int HMoveDistance { get; } // bir adımda ne kadar ilerlerleyeceğini belirler
        int EMoveDistance { get; } //dikey hareket mesafesini belirler

        /// <param name="direction">seçilen yön</param>
       
        bool DoMove (Direction direction); 
    }
}
