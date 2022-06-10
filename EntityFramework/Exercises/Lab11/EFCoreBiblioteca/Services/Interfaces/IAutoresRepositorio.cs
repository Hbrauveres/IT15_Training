using EFCoreBiblioteca.Models;
namespace EFCoreBiblioteca.Services.Interfaces;
public interface IAutoresRepositorio
{
    Task<Autor?> GetAutorAsync(int autorId);
    Task<IEnumerable<Autor>> GetAutoresAsync();
}