using Microsoft.AspNetCore.Mvc;

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
