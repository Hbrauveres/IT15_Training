using MVCCep.Models;
namespace MVCCep.Services;

public interface ICepService
{
    IEnumerable<ConsultaCep> ConsultaTodos();
    ConsultaCep? ConsutaPorCep(string cep);
    void Cadastrar(ConsultaCep cep);
}