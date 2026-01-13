using HelloWorldFromId.Models;
using HelloWorldFromId.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldFromId.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(IWeatherForecastService service) : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return service.GetForecast();
    }
}