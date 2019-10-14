using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using poc_azure_blazor.Data;

namespace poc_azure_blazor
{
    [Route("api/[controller]")]
    [Controller]
    public class ForecastController : Controller
    {
        private readonly WeatherForecastService weatherForecastService;

        public ForecastController(WeatherForecastService weatherForecastService)
        {
            this.weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> GetAsync()
        {
            var test = await this.weatherForecastService.GetForecastAsync(DateTime.Now);

            return test;
        }
    }
}
