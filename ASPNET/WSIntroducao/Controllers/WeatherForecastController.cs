using Microsoft.AspNetCore.Mvc;

namespace WSIntroducao.Controllers;

// Anotações - Atributo metadado que pode modificar o comportamento daquilo que esta anotado
[ApiController] // Anotação (atributo) -> disponibiliza conjunto de comportamentos préconfig do web service
                // Regras de mapeamento de URIs para metodos dentro de controladores

[Route("[controller]")] // Route -> Dentro do pipeline de processamento delega qual controlador
                        //          e qual metodo responde uma requisição via URI
                        //          .../WeatherForecast é direcionado para WeatherForecastController
public class WeatherForecastController : ControllerBase // O nome da classe terminar em xxxController É IMPORTANTE!!!
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    // Configuração de ponto de injeção de dependencias
    // Tudo que é dependencia externa ao meu serviço é obtido via instancia pronta
    // não é cirado uma "new" instacia.
    private readonly ILogger<WeatherForecastController> _logger; // Objeto que tem acesso ao sistema de loggin do ASP.NET

    public WeatherForecastController(ILogger<WeatherForecastController> logger) // No Construtor o ASP.NET percebe que é necessario um
    {                                                                           // objeto logger, então o subsistema de Injeção de Dep.
        _logger = logger;                                                       // instancia esse objeto e envia para o construtor.
    }                                                                           // Construtor guarda a referencia para esse objeto.

    //[OBS: Programe a favor no framework, não contra, UTILIZE INJEÇÃO DE DEPENDENCIAS]

    // Metodos do Controlador
    // Metodos podem ser acessados pelo mapeamento de uma URI para o metodo
    // através de atributos, por exemplo: [GET .../WeatherForecast] cai no seguinte metodo:
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("Foi realizada uma requisição GET");
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast // Retorna uma coleção de objetos(DTO) WeatherForecast
        {                                                                 // IEnumerable é serealizavel por json, por isso pode ser retornado
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
