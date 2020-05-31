using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDev
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
            Login();
        }
        static void Login()
        {
            View.Home.frmSignIn frm = new View.Home.frmSignIn();
            DialogResult dr = frm.ShowDialog();
            if (dr != DialogResult.OK)
            {
                Application.Exit();
                return;
            }
            Application.Run(new View.Home.frmMain());
        }
    }
}
