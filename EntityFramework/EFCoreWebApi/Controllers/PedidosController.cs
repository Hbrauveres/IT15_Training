using Microsoft.AspNetCore.Mvc;
using EFCoreWebApi.Models;
using EFCoreWebApi.Services;

namespace EFCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidosController : ControllerBase
{
    private readonly ILogger<CatalogoController> _logger;
    private readonly IProdutoRepositorio _produtorepositorio;

    public PedidosController(ILogger<CatalogoController> logger, IProdutoRepositorio produtorepositorio)
    {
        _logger = logger;
        _produtorepositorio = produtorepositorio;
    }
}