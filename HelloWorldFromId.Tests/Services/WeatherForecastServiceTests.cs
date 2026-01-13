using HelloWorldFromId.Services;

namespace HelloWorldFromId.Tests.Services;

public class WeatherForecastServiceTests
{
    private readonly WeatherForecastService _service = new();

    [Fact]
    public void GetForecast_ShouldReturnFiveItems()
    {
        var result = _service.GetForecast().ToList();

        Assert.NotNull(result);
        Assert.Equal(5, result.Count);
    }

    [Fact]
    public void GetForecast_ShouldHaveValidTemperatureRange()
    {
        var result = _service.GetForecast();

        foreach (var item in result)
        {
            Assert.InRange(item.TemperatureC, -20, 54);
        }
    }

    [Fact]
    public void GetForecast_ShouldHaveNonEmptySummary()
    {
        var result = _service.GetForecast();

        foreach (var item in result)
        {
            Assert.False(string.IsNullOrWhiteSpace(item.Summary));
        }
    }

    [Fact]
    public void GetForecast_ShouldHaveFutureDates()
    {
        var today = DateOnly.FromDateTime(DateTime.Now);
        var result = _service.GetForecast().ToList();

        for (var i = 0; i < result.Count; i++)
        {
            Assert.Equal(today.AddDays(i + 1), result[i].Date);
        }
    }
}