using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Weather_Forecast.Models;

namespace Weather_Forecast.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            WeatherForecast cw = new WeatherForecast();
            return View(cw);
        }

        [HttpGet]
        public IActionResult Location(string location)
         {
            List<Location> weatherLocationList = new List<Location>();
            string strURL = "https://www.metaweather.com/api/location/search/?query=" + location;
            string url = strURL.Replace("\"", "");

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    weatherLocationList = JsonConvert.DeserializeObject<List<Location>>(streamReader.ReadToEnd());
                }

                return Json(weatherLocationList);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult LocationForecast(int woeID)
        {

            WeatherForecast weatherLocationList = new WeatherForecast();
            string strURL = "https://www.metaweather.com/api/location/" +woeID +"/";
            string url = strURL.Replace("\"", "");

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    weatherLocationList = JsonConvert.DeserializeObject<WeatherForecast>(streamReader.ReadToEnd());
                }

                return Json(weatherLocationList.ConsolidatedWeather);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
