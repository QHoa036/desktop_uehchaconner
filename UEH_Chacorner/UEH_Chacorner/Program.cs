using System;
using System.Windows.Forms;

using UEH_Chacorner;
using UEH_Chacorner.Home;

namespace UEH_Chaconner
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRevenue());
        }
    }
}
