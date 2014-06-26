using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Device_Information_Store
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public static List<Device> deviceStoreList = new List<Device>();
        public static MainForm formMain;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new MainForm();
            Application.Run(formMain);
        }
    }
}
