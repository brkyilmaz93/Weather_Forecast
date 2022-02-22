
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather_Forecast.Models
{
    public class WeatherForecast
    {
        [JsonProperty(PropertyName = "consolidated_weather")]
        public List<ConsolidatedWeather> ConsolidatedWeather { get; set; }
        [JsonProperty(PropertyName = "time")]
        public DateTime Time { get; set; }
        [JsonProperty(PropertyName = "sun_rise")]
        public DateTime SunRise { get; set; }
        [JsonProperty(PropertyName = "sun_set")]
        public DateTime SunSet { get; set; }
        [JsonProperty(PropertyName = "timezone_name")]
        public string TimezoneName { get; set; }
        [JsonProperty(PropertyName = "parent")]
        public Location Location { get; set; }     
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "location_type")]
        public string LocationType { get; set; }
        [JsonProperty(PropertyName = "woeid")]
        public int WoeId { get; set; }
        [JsonProperty(PropertyName = "latt_long")]
        public string LattLong { get; set; }
        [JsonProperty(PropertyName = "timezone")]
        public string TimeZone { get; set; }
    }
}
