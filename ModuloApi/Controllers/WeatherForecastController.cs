using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Congelante", "Revigorante", "Fresco", "Frio", "Suave", "Quente", "Agradável", "Quente", "Abrasador", "Incandescente"
        };

        [HttpGet] // Desse modo, o endpoint será /WeatherForecast
        [ProducesResponseType(typeof(WeatherForecast[]), StatusCodes.Status200OK)]  // Anota o tipo de resposta para sucesso e código 200. Isso ajuda na documentação do Swagger, deixando claro o que a API retorna.
        public IActionResult GetWeatherForecast()
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    Summaries[Random.Shared.Next(Summaries.Length)]
                ))
                .ToArray();
            return Ok(forecast);
        }
    }

    public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}