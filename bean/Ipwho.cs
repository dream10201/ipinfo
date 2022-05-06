using ipinfo.bean.ipwho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ipinfo.bean
{
    [DataContract]
    internal class Ipwho
    {
        public const string url = "http://ipwho.is";

        [DataMember(Name = "ip")]
        public string Ip { get; set; }
        [DataMember(Name = "success")]
        public bool Success { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "continent")]
        public string Continent { get; set; }
        [DataMember(Name = "continent_code")]
        public string ContinentCode { get; set; }
        [DataMember(Name = "country")]
        public string Country { get; set; }
        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }
        [DataMember(Name = "region")]
        public string Region { get; set; }
        [DataMember(Name = "region_code")]
        public string RegionCode { get; set; }
        [DataMember(Name = "city")]
        public string City { get; set; }
        [DataMember(Name = "latitude")]
        public double Latitude { get; set; }
        [DataMember(Name = "longitude")]
        public double Longitude { get; set; }
        [DataMember(Name = "is_eu")]
        public bool IsEu { get; set; }
        [DataMember(Name = "postal")]
        public string Postal { get; set; }
        [DataMember(Name = "calling_code")]
        public string CallingCode { get; set; }
        [DataMember(Name = "capital")]
        public string Capital { get; set; }
        [DataMember(Name = "borders")]
        public string Borders { get; set; }
        [DataMember(Name = "flag")]
        public Flag Flag { get; set; }
        [DataMember(Name = "connection")]
        public Connection Connection { get; set; }
        [DataMember(Name = "timezone")]
        public Timezone Timezone { get; set; }
    }
}
