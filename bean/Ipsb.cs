using System.Runtime.Serialization;

namespace ipinfo.bean
{
    [DataContract]
    internal class Ipsb
    {
        public const string url = "https://api-ipv4.ip.sb/geoip";

        [DataMember(Name = "organization")]
        public string Organization { get; set; }
        [DataMember(Name = "ip")]
        public string Ip { get; set; }
        [DataMember(Name = "longitude")]
        public float Longitude { get; set; }
        [DataMember(Name = "city")]
        public string City { get; set; }
        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }
        [DataMember(Name = "isp")]
        public string Isp { get; set; }
        [DataMember(Name = "offset")]
        public int Offset { get; set; }
        [DataMember(Name = "region")]
        public string Region { get; set; }
        [DataMember(Name = "asn")]
        public int Asn { get; set; }
        [DataMember(Name = "asn_organization")]
        public string AsnOrganization { get; set; }
        [DataMember(Name = "country")]
        public string Country { get; set; }
        [DataMember(Name = "latitude")]
        public float Latitude { get; set; }
        [DataMember(Name = "continent_code")]
        public string ContinentCode { get; set; }
        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }
        [DataMember(Name = "region_code")]
        public string RegionCode { get; set; }
    }
}
