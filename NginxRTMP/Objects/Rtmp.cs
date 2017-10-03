using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NginxRTMP
{
    [XmlRoot("rtmp")]
    public class Rtmp
    {
        [XmlElement("nginx_version")]
        public string NginxVersion { get; set; }

        [XmlElement("nginx_rtmp_version")]
        public string NginxRtmpVersion { get; set; }

        [XmlElement("compiler")]
        public string Compiler { get; set; }

        [XmlElement("built")]
        public string Built { get; set; }

        [XmlElement("pid")]
        public int Pid { get; set; }

        [XmlElement("uptime")]
        public long Uptime { get; set; }

        [XmlElement("naccepted")]
        public int NAccepted { get; set; }

        [XmlAttribute("bw_in")]
        public long BwIn { get; set; }

        [XmlAttribute("bw_out")]
        public long BwOut { get; set; }

        [XmlAttribute("bytes_in")]
        public long BytesIn { get; set; }

        [XmlElement("server")]
        public Server Server { get; set; }
    }
}
