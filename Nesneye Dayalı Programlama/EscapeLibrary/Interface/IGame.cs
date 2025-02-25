using EscapeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeLibrary.Interface
{
    internal interface IGame
    {
        event EventHandler ElapsedTimeChanged;  // ElapsedTimeChanged olayı, geçen süre değiştikçe tetiklenen bir olaydır.
        bool IsContinue {  get; } // IsContinue özelliği, oyunun devam edip etmediğini belirtir.
        TimeSpan ElapsedTime { get; } // ElapsedTime özelliği, oyunun başlangıcından bu yana geçen süreyi temsil eder.
        void Start();
        void Pause();
        void Move(Direction direction);
    }
}
