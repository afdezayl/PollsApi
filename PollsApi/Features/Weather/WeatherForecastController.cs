using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PollsApi.Features.Weather.Services;

namespace PollsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)        {
            _logger = logger;
            _weatherService = weatherService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecast>> GetWeatherForecasts()
        {
            var forecasts = this._weatherService.GetWeatherForecasts();

            return Ok(forecasts);            
        }
    }
}
