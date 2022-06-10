using Microsoft.AspNetCore.Mvc;
using EFCoreBiblioteca.Services.Interfaces;
using EFCoreBiblioteca.Models;

namespace EFCoreBiblioteca.Controllers;

[ApiController]
[Route("[controller]")]
public class AutoresController : ControllerBase
{
    private readonly ILogger<AutoresController> _logger;
    private readonly ILivrosRepositorio _livrosRepositorio;
    private readonly IAutoresRepositorio _autoresRepositorio;

    public AutoresController(ILogger<AutoresController> logger, ILivrosRepositorio livrosRepositorio, IAutoresRepositorio autoresRepositorio)
    {
        _logger = logger;
        _livrosRepositorio = livrosRepositorio;
        _autoresRepositorio = autoresRepositorio;
    }

    
}

