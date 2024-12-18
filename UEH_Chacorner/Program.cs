﻿using System;
using System.Windows.Forms;
using UEH_Chacorner.Home;
using UEH_ChaCorner;
using UEH_ChaCorner.Home;

namespace UEH_ChaCorner
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
            Application.Run(new FMenu());
        }
    }
}
