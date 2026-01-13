using HelloWorldFromId.Services;
using HelloWorldFromId.Tests.Fake;

namespace HelloWorldFromId.Tests.Services;

public class WeatherForecastServiceTests
{
    private readonly WeatherForecastService _service;

    public WeatherForecastServiceTests()
    {
        var fakeRepository = new FakeWeatherForecastRepository();
        _service = new WeatherForecastService(fakeRepository);
    }

    [Fact]
    public async Task GetForecastAsync_ShouldReturnFiveItems()
    {
        var result = (await _service.GetForecastAsync()).ToList();

        Assert.Equal(5, result.Count);
    }

    [Fact]
    public async Task GetForecastAsync_ShouldFilterTemperatureCorrectly()
    {
        var result = await _service.GetForecastAsync();

        Assert.All(result, x => Assert.True(x.TemperatureC > -10));
    }

    [Fact]
    public async Task GetForecastAsync_ShouldHaveNonEmptySummary()
    {
        var result = await _service.GetForecastAsync();

        Assert.All(result, x => Assert.False(string.IsNullOrWhiteSpace(x.Summary)));
    }

    [Fact]
    public async Task GetForecastAsync_ShouldHaveFutureDates()
    {
        var today = DateOnly.FromDateTime(DateTime.Now);
        var result = (await _service.GetForecastAsync()).ToList();

        for (var i = 0; i < result.Count; i++)
        {
            Assert.Equal(today.AddDays(i + 1), result[i].Date);
        }
    }
}