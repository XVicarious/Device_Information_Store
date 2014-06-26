using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Device_Information_Store
{
    public partial class AddOtherDevice : Form
    {
        public Device device;
        public Device oldDevice;
        public AddOtherDevice(Device device)
        {
            InitializeComponent();
            if (device != null)
            {
                this.device = device;
                this.oldDevice = device;
                Program.deviceStoreList.Remove(oldDevice);
                Program.formMain.saveDatabase();
                Program.formMain.setCurrentModified(File.GetLastWriteTime("deviceList.xml"));
                this.textDeviceName.Text = device.deviceName;
                this.textDeviceIP.Text = device.deviceIP.getIPAddress();
                this.textDeviceType.Text = device.deviceType;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.oldDevice != null)
            {
                Program.deviceStoreList.Add(this.oldDevice);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.GetLastWriteTime("deviceList.xml").CompareTo(Program.formMain.getCurrentModified()) > 0)
            {
                Program.formMain.loadDatabase();
                if (Program.deviceStoreList.Contains(this.oldDevice))
                {
                    Program.deviceStoreList.Remove(this.oldDevice);
                }
            }
            if (device == null)
            {
                this.device = new Device();
                this.device.deviceName = textDeviceName.Text;
            }
            else
            {
                this.device.deviceName = textDeviceName.Text;
            }
            this.device.deviceIP = new IPAddress(textDeviceIP.Text);
            this.device.deviceType = textDeviceType.Text;
            Program.deviceStoreList.Add(this.device);
            Program.formMain.getFormDeviceList().refreshDeviceList();
            Program.formMain.saveDatabase();
            Program.formMain.setCurrentModified(File.GetLastWriteTime("deviceList.xml"));
            this.Close();
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
                if (s == "" || Int32.Parse(0 + s) > 255 || Int32.Parse(0 + s) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void textDeviceIP_TextChanged(object sender, EventArgs e)
        {
            if (!isInForm(textDeviceIP.Text))
            {
                textDeviceIP.ForeColor = Color.Red;
            }
            else
            {
                textDeviceIP.ForeColor = Color.Black;
            }
        }


    }
}
