﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo_Team
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
            try
            {
            Application.Run(new FormMain());
                Excel.getInstance().closeExcel();
            }
            catch {
                try
                {

                    Excel.getInstance().closeExcel();
                }
                catch { }

            }
        }
    }
}
