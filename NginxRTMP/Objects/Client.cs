using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NginxRTMP.Objects
{
    [XmlType("client")]
    public class Client
    {
        [XmlElement("id")]
        public int id { get; set; }
    }
}
