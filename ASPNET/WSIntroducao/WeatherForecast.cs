namespace WSIntroducao;

// CLASSE DTO -> Data Transfer Object
// Objeto com o unico proposito de serealizar dados em resposta.
// Em outras palavras:
// Ele da o formato dos dados que o web service vai devolver.
public class WeatherForecast 
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
