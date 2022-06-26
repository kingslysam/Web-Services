using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace citiesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private List<City> _city;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            StreamReader r = new StreamReader("file.json");
            string json = r.ReadToEnd();
            // dynamic json = System.IO.File.ReadAllText("file.json");
            this._city = JsonConvert.DeserializeObject<List<City>>(json);
            _logger = logger;
        }

        [HttpGet(Name = "GetCities")]
        public IEnumerable<Cities> Get()
        {
            return Enumerable.Range(1, 1000).Select(index => new Cities
            {
                Name = _city[index].city,
            })
                .ToArray();
        }
    }
}