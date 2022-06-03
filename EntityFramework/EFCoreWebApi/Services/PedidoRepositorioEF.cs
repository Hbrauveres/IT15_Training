using EFCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
namespace EFCoreWebApi.Services;

public class PedidoRepositorioEF : IPedidoRepositorio
{
    private readonly LojinhaContext _contexto;

    public PedidoRepositorioEF(LojinhaContext contexto)
    {
        _contexto = contexto;
    }
    public async Task<Pedido> AdicionarAsync(Pedido pedido)
    {
        await _contexto.Pedidos.AddAsync(pedido);
        await _contexto.SaveChangesAsync();
        return pedido;
    }
}
