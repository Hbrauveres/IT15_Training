using EFCoreBiblioteca.Models;
using EFCoreBiblioteca.Services.Interfaces;
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

    public async Task<IEnumerable<Livro>> GetLivrosByAutorAsync(int autorId)
    {
        var livros = await _contexto.LivroAutor
            .Include(la => la.Livro)
            .Include(la => la.Autor)
            .Where(la => la.AutorId == autorId)
            .Select(la => la.Livro)
            .ToListAsync();
        
        return livros;
    }
}