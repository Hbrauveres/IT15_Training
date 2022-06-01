using MVCCep.Models;
using System.Collections.Concurrent;
namespace MVCCep.Services;

public class CepMemoriaService : ICepService
{
    private readonly ConcurrentDictionary<string, ConsultaCep> _dados = 
        new ConcurrentDictionary<string, ConsultaCep>();

    public CepMemoriaService()
    {
        _dados.TryAdd("90619900", new ConsultaCep{
                Logradouro = "Avenida Ipiranga, 6681",
                Bairro = "Partenon",
                Cidade = "Porto Alegre",
                Estado = "RS",
                Cep = "90619900"
            });
        _dados.TryAdd("01001000", new ConsultaCep{
                Logradouro = "´Praça da Sé",
                Bairro = "Sé",
                Cidade = "São Paulo",
                Estado = "SP",
                Cep = "01001000"
            });
    }
    public void Cadastrar(ConsultaCep cep)
    {
        _dados.TryAdd(cep.Cep, cep);
    }

    public IEnumerable<ConsultaCep> ConsultaTodos()
    {
        return _dados.Values.ToArray();
    }

    public ConsultaCep? ConsutaPorCep(string cep)
    {
        ConsultaCep? resultado;
        _dados.TryGetValue(cep, out resultado);
        return resultado;
    }
}