using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather_Forecast.Models
{
    public class ConsolidatedWeather
    {
        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }
        [JsonProperty(PropertyName = "air_pressure")]
        public decimal AirPressure { get; set; }
        [JsonProperty(PropertyName = "applicable_date")]
        public DateTime ApplicableDate { get; set; }
        [JsonProperty(PropertyName = "humidity")]
        public decimal Humidity { get; set; }
        [JsonProperty(PropertyName = "max_temp")]
        public long MaxTemp { get; set; }
        [JsonProperty(PropertyName = "min_temp")]
        public long MinTemp { get; set; }
        [JsonProperty(PropertyName = "predictability")]
        public long Predictability { get; set; }
        [JsonProperty(PropertyName = "the_temp")]
        public long TheTemp { get; set; }
        [JsonProperty(PropertyName = "visibility")]
        public decimal? Visibility { get; set; }
        [JsonProperty(PropertyName = "weather_state_abbr")]
        public string WeatherStateAbbr { get; set; }
        [JsonProperty(PropertyName = "weather_state_name")]
        public string WeatherStateName { get; set; }
        [JsonProperty(PropertyName = "wind_direction")]
        public string WindDirection { get; set; }
        [JsonProperty(PropertyName = "wind_direction_compass")]
        public string WindDirectionCompass { get; set; }
        [JsonProperty(PropertyName = "wind_speed")] 
        public string WindSpeed { get; set; }
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }
    }
}
