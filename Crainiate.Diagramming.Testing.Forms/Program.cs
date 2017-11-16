using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Crainiate.Diagramming.Testing
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
            
            //Application.Run(new frmBlockLine());
            //Application.Run(new frmConnector());
            //Application.Run(new frmGroup());
            //Application.Run(new frmLink());
            //Application.Run(new frmPalette());
            //Application.Run(new frmPath());
            //Application.Run(new frmTable());
            Application.Run(new frmTreeLine());
       
        }
    }
}