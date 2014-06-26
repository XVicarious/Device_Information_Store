using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Device_Information_Store
{
    [Serializable]
    [XmlRoot("Route")]
    public class Route
    {
        [XmlElement("routeDestination")]
        public IPAddress destination;
        [XmlElement("routeMask")]
        public IPAddress mask;
        [XmlElement("routeGateway")]
        public IPAddress gateway;
        public Route() { }
        public Route(IPAddress destination, IPAddress mask, IPAddress gateway)
        {
            this.destination = destination;
            this.mask = mask;
            this.gateway = gateway;
        }
    }
}
