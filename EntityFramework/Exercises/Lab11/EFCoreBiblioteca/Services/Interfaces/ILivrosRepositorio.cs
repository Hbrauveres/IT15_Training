using EFCoreBiblioteca.Models;
namespace EFCoreBiblioteca.Services.Interfaces;

public interface ILivrosRepositorio
{
    Task<IEnumerable<Livro>> GetLivrosAsync();
    Task<Livro> GetLivroAsync(int id);
    Task<IEnumerable<Livro>> GetLivrosByAutorAsync(int autorId);
}