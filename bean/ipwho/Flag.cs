using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ipinfo.bean.ipwho
{
    [DataContract]
    internal class Flag
    {
        [DataMember(Name = "img")]
        public string Img { get; set; }
        [DataMember(Name = "emoji")]
        public string Emoji { get; set; }
        [DataMember(Name = "emoji_unicode")]
        public string EmojiUnicode { get; set; }
    }
}
