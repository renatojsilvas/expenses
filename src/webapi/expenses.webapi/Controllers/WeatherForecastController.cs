using Microsoft.AspNetCore.Mvc;

namespace expenses.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    private static Guid? Id = null;

    [HttpGet(Name = "GetId")]
    public string GetId()
    {
        if (Id is null)
        {
            Id = Guid.NewGuid();
        }

        return Id.ToString();
    }
}
