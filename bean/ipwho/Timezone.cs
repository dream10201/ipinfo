using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ipinfo.bean.ipwho
{
    [DataContract]
    internal class Timezone
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "abbr")]
        public string Abbr { get; set; }
        [DataMember(Name = "is_dst")]
        public bool IsDst { get; set; }
        [DataMember(Name = "offset")]
        public int Offset { get; set; }
        [DataMember(Name = "utc")]
        public string Utc { get; set; }
        [DataMember(Name = "current_time")]
        public string CurrentTime { get; set; }
    }
}
