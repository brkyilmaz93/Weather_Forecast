using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather_Forecast.Models
{
    public class Location
    {
        [JsonProperty(PropertyName ="title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "location_type")]

        public string LocationType { get; set; }
        [JsonProperty(PropertyName = "woeid")]

        public int WoeID { get; set; }
        [JsonProperty(PropertyName = "latt_long")]

        public string LattLong { get; set; }
    }
}
