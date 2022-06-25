using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<string> Get(string cityName)
        {
            var URL = $"http://api.weatherapi.com/v1/current.json?key=be643e728628467288b130853222506 &q={cityName}&aqi=no";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            return await response.Content.ReadAsStringAsync();
        }
    }
}