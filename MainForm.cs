using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Device_Information_Store
{
    public partial class MainForm : Form
    {

        public static Form1 formDeviceList;
        public static AddComputerForm formAddComputer;

        public MainForm()
        {
            InitializeComponent();
            computerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            refreshDeviceListToolStripMenuItem.ShortcutKeys = Keys.F5;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formDeviceList = new Form1();
            formDeviceList.MdiParent = this;
            formDeviceList.Show();
        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAddComputer = new AddComputerForm(null);
            formAddComputer.MdiParent = this;
            formAddComputer.Show();
        }

        private void refreshDeviceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formDeviceList.deviceList.Items.Clear();
            formDeviceList.deviceList.DataSource = Program.deviceStoreList;
            formDeviceList.deviceList.DisplayMember = "deviceName";
            //foreach (Device device in Program.deviceStoreList)
            //{
            //    formDeviceList.deviceList.Items.Add(device);
            //}
        }

        public Form1 getFormDeviceList()
        {
            return formDeviceList;
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer s = new XmlSerializer(Program.deviceStoreList.GetType());
            using (TextWriter w = new StreamWriter("deviceList.xml"))
            {
                s.Serialize(w, Program.deviceStoreList);
            }
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer s = new XmlSerializer(Program.deviceStoreList.GetType());
            using (TextReader w = new StreamReader("deviceList.xml"))
            {
                Program.deviceStoreList = (List<Device>)s.Deserialize(w);
            }
        }

    }
}
