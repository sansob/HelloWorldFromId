using HelloWorldFromId.Models;
using HelloWorldFromId.Repositories;

namespace HelloWorldFromId.Services;

public class WeatherForecastService(IWeatherForecastRepository repository) : IWeatherForecastService
{
    public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
    {
        var data = await repository.GetAsync();
        return data.Where(x => x.TemperatureC > -10);
    }
}