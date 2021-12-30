using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joyeria2._0
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]//C:\Users\Roberto\Desktop\Nueva carpeta (2)\Trabajo del indelfonso\4to\Joyeria2.0\Joyeria2.0\Program.cs
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmlogin());
        }
    }
}
