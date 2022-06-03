using EFCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
namespace EFCoreWebApi.Services;

public class ProdutoRepositorioEF : IProdutoRepositorio
{
    private readonly LojinhaContext _contexto;

    public ProdutoRepositorioEF(LojinhaContext contexto)
    {
        _contexto = contexto;
    }
  
    public async Task<Produto> ConsultarAsync(int id)
    {
        var produto = await _contexto.Produtos.FindAsync(id);
        if (produto is null)
        {
            throw new ProdutoNaoEncontradoException(id);
        }
        return produto;
    }

    public async Task<IEnumerable<Produto>> ConstultarTodosAsync()
    {
        return await _contexto.Produtos.ToListAsync();
    }
}