using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

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
            if (!File.Exists("deviceList.xml"))
            {
                XmlSerializer s = new XmlSerializer(deviceStoreList.GetType());
                using (TextWriter w = new StreamWriter("deviceList.xml"))
                {
                    s.Serialize(w, deviceStoreList);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new MainForm();
            Application.Run(formMain);
        }
    }
}
