using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DecideForMe
{
    static class Program
    {
        public static DecideForMe.Form1 ms = new Form1();
        public static DecideForMe.Setup ss = new Setup();
        public static DecideForMe.IntWizard iw = new IntWizard();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(ms);
        }
    }
}
