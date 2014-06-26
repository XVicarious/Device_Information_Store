using System;
using System.Xml.Serialization;

namespace Device_Information_Store
{
    [Serializable]
    [XmlRoot("Route")]
    public class Route
    {
        public IPAddress[] routeL;
        public Route() { }
        public Route(IPAddress destination, IPAddress mask, IPAddress gateway)
        {
            routeL = new IPAddress[] { destination, mask, gateway };
        }
    }
}
