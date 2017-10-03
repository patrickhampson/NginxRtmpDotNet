using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NginxRTMP
{
    [XmlType("server")]
    public class Server
    {
        [XmlElement("application")]
        public Application[] Applications { get; set; }
    }
}
