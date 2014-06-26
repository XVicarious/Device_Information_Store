using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Device_Information_Store
{
    public partial class AddComputerForm : Form
    {

        private Computer computer;
        private Computer oldComputer;
        private BindingSource sourceWinKeys = new BindingSource();

        public AddComputerForm(Computer computer)
        {
            InitializeComponent();
            if (computer != null)
            {
                this.computer = computer;
                this.oldComputer = computer;
                Program.deviceStoreList.Remove(oldComputer);
                loadComputerObject();
            }
            else
            {
                this.computer = new Computer("");
            }
        }

        private void loadComputerObject()
        {
            // Basic computer information
            this.textDeviceName.Text = this.computer.deviceName;
            this.textIPAddress.Text = this.computer.deviceIP.getIPAddress();
            // Windows Information
            this.comboWindowsVersion.SelectedItem = this.computer.windowsVersion;
            this.comboWindowsArch.SelectedItem = this.computer.windowsArchitecture;
            sourceWinKeys.DataSource = this.computer.windowsKeys;
            this.listWindowsKeys.DataSource = sourceWinKeys;
            // Office Information
            // Users Information
            // Attached Devices
            // Persistant Routes
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (computer == null)
            {
                this.computer = new Computer(textDeviceName.Text);
            }
            else
            {
                this.computer.deviceName = textDeviceName.Text;
            }
            this.computer.deviceIP = new IPAddress(textIPAddress.Text);
            this.computer.deviceType = textDeviceType.Text;
            this.computer.officeKey = textOfficeKey.Text;
            this.computer.officeVersion = (String)comboOfficeVersions.SelectedItem;
            this.computer.windowsArchitecture = (String)comboWindowsArch.SelectedItem;
            this.computer.windowsVersion = (String)comboWindowsVersion.SelectedItem;
            //this.computer.computerUsers = listUsers.Items;
            Program.deviceStoreList.Add(this.computer);
            Program.formMain.getFormDeviceList().refreshDeviceList();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!isInForm(textIPAddress.Text))
            {
                textIPAddress.ForeColor = Color.Red;
            }
            else { textIPAddress.ForeColor = Color.Black;  }
        }

        private Boolean isInForm(String name)
        {
            string[] octs = name.Split('.');
            if (octs.Length != 4)
            {
                return false;
            }
            foreach (String s in octs)
            {
                if (Int32.Parse(0 + s) > 255 || Int32.Parse(0 + s) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (this.oldComputer != null)
            {
                Program.deviceStoreList.Add(this.oldComputer);
            }
            this.Close();
        }

        private void buttonAddWinKey_Click(object sender, EventArgs e)
        {

            String key = Microsoft.VisualBasic.Interaction.InputBox("Enter Windows Key");
            if (key != "") {
                try
                {
                    this.computer.windowsKeys.Add(key);
                }
                catch (NullReferenceException exception)
                {
                    this.computer.windowsKeys = new List<String>();
                    this.computer.windowsKeys.Add(key);
                }
            }
            listWindowsKeys.DataSource = sourceWinKeys;

        }

    }
}
