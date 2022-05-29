try
{
    Console.WriteLine("Consumindo Via Cep V1");
    var resultado = await ViaCepConsumidor.Consultar("01001000");
    Console.WriteLine($"Sucesso: {resultado.IsSuccessStatusCode}");
    Console.WriteLine($"Cod Status: {resultado.StatusCode}");
    var dados = await resultado.Content.ReadAsStringAsync();
    Console.WriteLine(dados);

    Console.WriteLine("Consumindo Via Cep V2");
    var resultado2 = await ViaCepConsumidor.ConsultarV2("01001000");
    Console.WriteLine(resultado2);

    Console.WriteLine("Consumindo Via Cep V3");
    var resultado3 = await ViaCepConsumidor.ConsultarV3("91210120");
    Console.WriteLine(resultado3);
}
catch(System.Exception)
{
    throw;
}


