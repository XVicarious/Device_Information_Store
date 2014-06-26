using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Device_Information_Store
{
    [Serializable]
    [XmlRoot("Computer")]
    public class Computer : Device
    {
        [XmlElement("WindowsVersion")]
        public String windowsVersion;
        [XmlElement("WindowsArchitecture")]
        public String windowsArchitecture;
        [XmlElement("WindowsKeys")]
        public List<String> windowsKeys;
        [XmlElement("OfficeVersion")]
        public String officeVersion;
        [XmlElement("OfficeKey")]
        public String officeKey;
        [XmlElement("PersistantRoutes")]
        public List<Route> persistantRoutes;
        [XmlElement("ComputerUsers")]
        public List<String> computerUsers;
        [XmlElement("AttachedDevices")]
        public List<Device> attachedDevices;

        public Computer() { }

        public Computer(String deviceName)
        {
            this.deviceType = "Computer";
            this.deviceName = deviceName;
            windowsVersion = "Windows 7 Professional";
            windowsArchitecture = "x86_64";
            officeVersion = "";
            officeKey = "";
            persistantRoutes = new List<Route>();
            computerUsers = new List<String>();
            attachedDevices = new List<Device>();
            windowsKeys = new List<String>();
        }

        public Computer(String deviceName, String windowsVersion)
        {
            this.deviceType = "Computer";
            this.deviceName = deviceName;
            this.windowsVersion = windowsVersion;
            windowsArchitecture = "x86_64";
            officeVersion = "";
            officeKey = "";
            persistantRoutes = new List<Route>();
            computerUsers = new List<String>();
            attachedDevices = new List<Device>();
            windowsKeys = new List<String>();
        }

        public Computer(String deviceName, String windowsVersion, String windowsArchitecture)
        {
            this.deviceType = "Computer";
            this.deviceName = deviceName;
            this.windowsVersion = windowsVersion;
            this.windowsArchitecture = windowsArchitecture;
            officeVersion = "";
            officeKey = "";
            persistantRoutes = new List<Route>();
            computerUsers = new List<String>();
            attachedDevices = new List<Device>();
            windowsKeys = new List<String>();
        }

        public Boolean equals(Computer other)
        {
            if (this.deviceIP.getIPAddress() == other.deviceIP.getIPAddress())
            {
                return true;
            }
            return false;
        }
    }
}
