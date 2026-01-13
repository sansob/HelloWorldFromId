using HelloWorldFromId.Models;

namespace HelloWorldFromId.Services;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetForecast();
}