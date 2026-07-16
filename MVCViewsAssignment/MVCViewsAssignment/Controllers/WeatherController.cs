using Microsoft.AspNetCore.Mvc;
using MVCViewsAssignment.Models;

namespace MVCViewsAssignment.Controllers
{
    public class WeatherController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            List<CityWeather> cityWeathers = new List<CityWeather>
            {
                new CityWeather { CityUniqeCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33, humidity = 50, windSpeed = 15, weather = "Clouds" },
                new CityWeather { CityUniqeCode = "NYC", CityName = "New York", DateAndTime = DateTime.Parse("2030-01-01 3:00"), TemperatureFahrenheit = 60, humidity = 60, windSpeed = 20, weather = "Clear" },
                new CityWeather { CityUniqeCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"), TemperatureFahrenheit = 82, humidity = 70, windSpeed = 25, weather = "Rain" }
            };
            return View(cityWeathers);
        }

        [Route("/Weather/{cityCode}")]
        public IActionResult WeatherWithCity(string cityCode)
        {
            List<CityWeather> cityWeathers = new List<CityWeather>
            {
                new CityWeather { CityUniqeCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33, humidity = 50, windSpeed = 15, weather = "Clouds" },
                new CityWeather { CityUniqeCode = "NYC", CityName = "New York", DateAndTime = DateTime.Parse("2030-01-01 3:00"), TemperatureFahrenheit = 60, humidity = 60, windSpeed = 20, weather = "Clear" },
                new CityWeather { CityUniqeCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"), TemperatureFahrenheit = 82, humidity = 70, windSpeed = 25, weather = "Rain" }
            };
            
            CityWeather? cityWeather = cityWeathers.FirstOrDefault(c => c.CityUniqeCode == cityCode.ToUpper());
            return View(cityWeather);
        }
    }
}
