using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            do
            {
                Komunikacija.Instanca.PokreniLogin = false;
                new FrmPrijavljivanje().ShowDialog();

            } while (Komunikacija.Instanca.PokreniLogin);
            
        }
    }
}
