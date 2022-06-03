using EFCoreWebApi.Models;
namespace EFCoreWebApi.Services;


public interface IPedidoRepositorio
{
    Task<Pedido> AdicionarAsync(Pedido pedido);
}