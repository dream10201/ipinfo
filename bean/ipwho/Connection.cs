using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ipinfo.bean.ipwho
{
    [DataContract]
    internal class Connection
    {
        [DataMember(Name = "asn")]
        public int Asn { get; set; }
        [DataMember(Name = "org")]
        public string Org { get; set; }
        [DataMember(Name = "isp")]
        public string Isp { get; set; }
        [DataMember(Name = "domain")]
        public string Domain { get; set; }
    }
}
