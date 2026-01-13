using HelloWorldFromId.Models;

namespace HelloWorldFromId.Services;

public interface IWeatherForecastService
{
    Task<IEnumerable<WeatherForecast>> GetForecastAsync();
}