using System;
using System.Xml.Serialization;

namespace Device_Information_Store
{
    [Serializable]
    [XmlRoot("Device")]
    [XmlInclude(typeof(Computer))]
    public class Device
    {
        [XmlElement("DeviceName")]
        public String deviceName { get; set; }
        [XmlElement("DeviceIP")]
        public IPAddress deviceIP { get; set; }
        [XmlElement("DeviceType")]
        public String deviceType { get; set; }
        public Device() { }
    }
}
