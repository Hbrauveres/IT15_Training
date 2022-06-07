using EFCoreBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBiblioteca.Services;

public class LivrosRepositorioEF : ILivrosRepositorio
{
    private readonly BibliotecaContext _contexto;

    public LivrosRepositorioEF(BibliotecaContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<Livro> GetLivroAsync(int id)
    {
        var livro = await _contexto.Livros.FindAsync(id);
        if (livro == null)
        {
            throw new LivroNaoEncontradoException(id);
        }
        return livro;
    }

    public async Task<IEnumerable<Livro>> GetLivrosAsync()
    {
        return await _contexto.Livros.ToListAsync();
    }
}