using EFCoreBiblioteca.Models;
namespace EFCoreBiblioteca.Services;

public interface ILivrosRepositorio
{
    Task<IEnumerable<Livro>> GetLivrosAsync();
    Task<Livro> GetLivroAsync(int id);
}