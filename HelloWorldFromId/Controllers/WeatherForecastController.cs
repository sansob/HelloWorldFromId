using HelloWorldFromId.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldFromId.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(IWeatherForecastService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await service.GetForecastAsync());
    }
}