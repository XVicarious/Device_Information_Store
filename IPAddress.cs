using System;
using System.Xml.Serialization;

namespace Device_Information_Store
{
    [Serializable]
    [XmlRoot("IP")]
    public class IPAddress
    {

        [XmlElement("IPOctets")]
        public byte[] octets;

        public IPAddress() { }

        public IPAddress(byte first, byte second, byte third, byte fourth)
        {
            this.octets = new byte[] { first, second, third, fourth };
        }

        public IPAddress(String ip)
        {
            octets = new byte[4];
            string[] octs = ip.Split('.');
            for (int i = 0; i < octs.Length; i++)
            {
                octets[i] = (byte)Convert.ToInt32(octs[i]);
            }
        }

        /// <summary>
        /// Retrieves the IP address from octets[] to a string
        /// </summary>
        /// <returns>An IP address in the form of [byte].[byte].[byte].[byte]</returns>
        public String getIPAddress()
        {
            String ipaddress = "";
            for (int i = 0; i < octets.Length; i++)
            {
                ipaddress += octets[i];
                if (i < octets.Length - 1)
                {
                    ipaddress += ".";
                }
            }
            return ipaddress;
        }
    }
}
