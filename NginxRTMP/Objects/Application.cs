using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using NginxRTMP.Objects;

namespace NginxRTMP
{
    [XmlType("application")]
    public class Application
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("live")]
        public Live Live { get; set; }

        [XmlElement("nclients")]
        public int NClients { get; set; }
    }
}
