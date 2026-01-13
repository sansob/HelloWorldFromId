using HelloWorldFromId.Models;
using HelloWorldFromId.Repositories;

namespace HelloWorldFromId.Tests.Fake;

public class FakeWeatherForecastRepository : IWeatherForecastRepository
{
    public Task<IEnumerable<WeatherForecast>> GetAsync()
    {
        var today = DateOnly.FromDateTime(DateTime.Now);

        var data = Enumerable.Range(1, 5)
            .Select(i => new WeatherForecast
            {
                Date = today.AddDays(i),
                TemperatureC = i * 5, // deterministic
                Summary = $"summary-{i}"
            });

        return Task.FromResult(data);
    }
}