namespace MVCViewsAssignment.Models
{
    public class CityWeather
    {
        public string? CityUniqeCode { get; set; }
        public string? CityName { get; set; }

        public DateTime? DateAndTime { get; set; }

        public int? TemperatureFahrenheit { get; set; }
        public int? humidity { get; set; }
        public int? windSpeed { get; set; }

        public string weather { get; set;  }
}
}
