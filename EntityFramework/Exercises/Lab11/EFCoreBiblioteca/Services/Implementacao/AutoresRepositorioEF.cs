using EFCoreBiblioteca.Models;
using EFCoreBiblioteca.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBiblioteca.Services;

public class AutoresRepositorioEF : IAutoresRepositorio
{
    private readonly BibliotecaContext _contexto;

    public AutoresRepositorioEF(BibliotecaContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<Autor?> GetAutorAsync(int id)
    {
        return await _contexto.Autores.FindAsync(id);
    }

    public async Task<IEnumerable<Autor>> GetAutoresAsync()
    {
        return await _contexto.Autores.ToListAsync();
    }
}