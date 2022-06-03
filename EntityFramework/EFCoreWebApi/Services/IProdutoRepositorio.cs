using EFCoreWebApi.Models;
namespace EFCoreWebApi.Services;

public interface IProdutoRepositorio
{
    Task<IEnumerable<Produto>> ConstultarTodosAsync();
    Task<Produto> ConsultarAsync(int id);
}