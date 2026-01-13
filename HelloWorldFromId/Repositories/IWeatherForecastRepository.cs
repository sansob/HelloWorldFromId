using HelloWorldFromId.Models;

namespace HelloWorldFromId.Repositories;

public interface IWeatherForecastRepository
{
    Task<IEnumerable<WeatherForecast>> GetAsync();
}