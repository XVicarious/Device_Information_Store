using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Device_Information_Store
{
    public partial class Form1 : Form
    {

        public BindingSource deviceListBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            deviceList.SelectedItem = null;
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
            if (deviceList.SelectedItem.GetType() == typeof(Computer))
            {
                AddComputerForm cForm = new AddComputerForm((Computer)deviceList.SelectedItem);
                cForm.MdiParent = Program.formMain;
                cForm.Show();
            }
            else
            {
                AddOtherDevice cForm = new AddOtherDevice((Device)deviceList.SelectedItem);
                cForm.MdiParent = Program.formMain;
                cForm.Show();
            }

        }

        private void listboxMenu_Opening(object sender, CancelEventArgs e)
        {
        }

        private void deviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void deviceList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                deviceList.SelectedIndex = deviceList.IndexFromPoint(e.Location);
                if (deviceList.SelectedIndex != -1)
                {
                    listboxMenu.Show(Cursor.Position);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete the selected item?  It is unrecoverable.  The database is saved after every operation, including deletion.  So I must ask again.... ARE YOU SURE YOU WANT TO DELETE THIS ITEM?", "CONFIRM THE TERMINATION OF THIS DEVICE FROM THE DEVICE LIST", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                Program.deviceStoreList.Remove((Device)deviceList.SelectedItem);
                Program.formMain.saveDatabase();
            }
        }

    }
}
