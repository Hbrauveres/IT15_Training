using Microsoft.AspNetCore.Mvc;
using EFCoreWebApi.Models;
using EFCoreWebApi.Services;

namespace EFCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogoController : ControllerBase
{
    private readonly ILogger<CatalogoController> _logger;
    private readonly IProdutoRepositorio _produtorepositorio;

    public CatalogoController(ILogger<CatalogoController> logger, IProdutoRepositorio produtorepositorio)
    {
        _logger = logger;
        _produtorepositorio = produtorepositorio;
    }

    // GET .../Catalogo
    [HttpGet]
    public Task<IEnumerable<Produto>> GetTodosProdutos()
    {
        return _produtorepositorio.ConstultarTodosAsync();
    }
    
    // GET .../Catalogo/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Produto>> GetPorId(int id)
    {
        try
        {
            var produto = await _produtorepositorio.ConsultarAsync(id);
            return produto;    
        }
        catch (ProdutoNaoEncontradoException)
        {
            return NotFound();
        }
    }
}
