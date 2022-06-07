using Microsoft.AspNetCore.Mvc;
using EFCoreBiblioteca.Services;
using EFCoreBiblioteca.Models;

namespace EFCoreBiblioteca.Controllers;

[ApiController]
[Route("[controller]")]
public class BibliotecaController : ControllerBase
{
    private readonly ILogger<BibliotecaController> _logger;

    public BibliotecaController(ILogger<BibliotecaController> logger)
    {
        _logger = logger;
    }
}

