using System;
using System.Windows.Forms;

namespace Device_Information_Store
{
    public partial class Form1 : Form
    {

        public BindingSource deviceListBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            deviceList.DisplayMember = "deviceName";
            deviceListBinding.DataSource = Program.deviceStoreList;
            deviceList.DataSource = deviceListBinding;
        }

        public void refreshDeviceList()
        {
            deviceList.DataSource = Program.deviceStoreList;
            deviceList.DisplayMember = "deviceName";
        }

        private void deviceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddComputerForm cForm = new AddComputerForm((Computer)deviceList.SelectedItem);
            cForm.MdiParent = Program.formMain;
            cForm.Show();
        }

        private void deviceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
