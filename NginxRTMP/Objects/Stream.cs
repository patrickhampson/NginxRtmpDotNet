using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NginxRTMP.Objects
{
    [XmlType("stream")]
    public class Stream
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("time")]
        public long Time { get; set; }

        /*[XmlAttribute("bw_in")]
        public long BwIn { get; set; }

        [XmlAttribute("bytes_in")]
        public long BytesIn { get; set; }

        [XmlAttribute("bw_out")]
        public long BwOut { get; set; }

        [XmlAttribute("bytes_in")]
        public long BytesOut { get; set; }

        [XmlAttribute("bw_data")]
        public long BwData { get; set; }*/

        [XmlElement("client")]
        public Client[] Clients { get; set; }

        //meta

        [XmlElement("nclients")]
        public int NCLients { get; set; }

        //publishing

        //active
    }
}
