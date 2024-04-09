using System;

namespace EventPlanning
{
    public class OutdoorGathering : Event
    {
        private string weatherForecast;

        public string WeatherForecast { get => weatherForecast; set => weatherForecast = value; }

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) 
            : base(title, description, date, time, address)
        {
            WeatherForecast = weatherForecast;
        }

        public override string GenerateFullMessage()
        {
            return $"{base.GenerateFullMessage()}\nWeather Forecast: {WeatherForecast}";
        }
    }
}
