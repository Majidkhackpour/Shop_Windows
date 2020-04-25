using System;
using System.Windows.Forms;
using EntityCache.Assistence;

namespace Shop_Windows
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

            ClsCache.Init();

            Application.Run(new frmMain());
        }
    }
}
