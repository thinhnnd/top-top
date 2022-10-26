using Microsoft.AspNetCore.Mvc;

namespace VideoService.Controllers;

[ApiController]
[Route("[controller]")]
public class VideoController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<VideoController> _logger;
    private readonly IConfiguration _configuration;

    public VideoController(ILogger<VideoController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet]
    public string Get()
    {
        return "Hello world";
    }
}
