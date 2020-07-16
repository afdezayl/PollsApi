using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollsApi.Features.Weather.Services
{
    public interface IWeatherService
    {
        public IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
