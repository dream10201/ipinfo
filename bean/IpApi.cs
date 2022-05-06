using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ipinfo.bean
{
    [DataContract]
    internal class IpApi
    {
        public const string url = "http://ip-api.com/json?fields=status,message,continent,continentCode,country,countryCode,region,regionName,city,district,zip,lat,lon,timezone,offset,currency,isp,org,as,asname,reverse,mobile,proxy,hosting,query";
        [DataMember(Name = "status")]
        public string Status { get; set; }
        [DataMember(Name = "continent")]
        public string Continent { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }
        [DataMember(Name = "countryCode")]
        public string CountryCode { get; set; }
        [DataMember(Name = "region")]
        public string Region { get; set; }
        [DataMember(Name = "regionName")]
        public string RegionName { get; set; }
        [DataMember(Name = "city")]
        public string City { get; set; }
        [DataMember(Name = "district")]
        public string District { get; set; }
        [DataMember(Name = "zip")]
        public string Zip { get; set; }
        [DataMember(Name = "lat")]
        public double Lat { get; set; }
        [DataMember(Name = "lon")]
        public double Lon { get; set; }
        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }
        [DataMember(Name = "offset")]
        public int Offset { get; set; }
        [DataMember(Name = "currency")]
        public string Currency { get; set; }
        [DataMember(Name = "isp")]
        public string Isp { get; set; }
        [DataMember(Name = "org")]
        public string Org { get; set; }
        [DataMember(Name = "as")]
        public string As { get; set; }
        [DataMember(Name = "asname")]
        public string AsName { get; set; }
        [DataMember(Name = "reverse")]
        public string Reverse { get; set; }
        [DataMember(Name = "mobile")]
        public bool Mobile { get; set; }
        [DataMember(Name = "proxy")]
        public bool Proxy { get; set; }
        [DataMember(Name = "hosting")]
        public bool Hosting { get; set; }
        [DataMember(Name = "query")]
        public string Query { get; set; }
    }
}
