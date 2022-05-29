using System.Net.Http.Json;
public static class ViaCepConsumidor
{
    public const string URI_BASE = "https://viacep.com.br/ws";
    private static readonly HttpClient client = new HttpClient();

    public static Task<HttpResponseMessage> Consultar(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json";
        return client.GetAsync(uri);
    }

    public static async Task<string> ConsultarV2(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json";
        var resultado = await client.GetAsync(uri);
        if (!resultado.IsSuccessStatusCode)
        {
            throw new Exception("Falha de consulta ao ViaCep");
        }
        
        return await resultado.Content.ReadAsStringAsync();
    }

    public static async Task<CEP?> ConsultarV3(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json";
        var resultado = await client.GetAsync(uri);
        if (!resultado.IsSuccessStatusCode)
        {
            throw new Exception("Falha de consulta ao ViaCep");
        }
        
        var dados = await resultado.Content.ReadFromJsonAsync<CEP>();
        
        if (dados is not null && dados.Erro is null) return dados;
        return null;
    }
}