using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeGame
{
    internal static class Program
    {
        // Uygulamanın ana giriş noktası.
        [STAThread]
        static void Main()
        {
            // Uygulama için görsel stilleri etkinleştir
            Application.EnableVisualStyles();
            // Metin rendereleme uyumluluğunu belirle.
            Application.SetCompatibleTextRenderingDefault(false);
            // Uygulamayı başlat ve ana formu (Level1) çalıştır.
            Application.Run(new Level1());
        }
    }
}
