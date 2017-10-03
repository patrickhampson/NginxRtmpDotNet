using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NginxRTMP.Objects
{
    [XmlType("live")]
    public class Live
    {
        [XmlElement("nclients")]
        public int NClients { get; set; }

        [XmlElement("stream")]
        public Stream Stream { get; set; }
    }
}
