using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inscripsoft
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreen1 sp = new SplashScreen1();
            if (sp.ShowDialog() == DialogResult.OK) 
            {
                Application.Run(new InscripSoft());
            }

          
        }
    }
}
