using Microsoft.AspNetCore.Mvc;
using EFCoreBiblioteca.Services;
using EFCoreBiblioteca.Models;

namespace EFCoreBiblioteca.Controllers;

[ApiController]
[Route("[controller]")]
public class LivrosController : ControllerBase
{
    private readonly ILogger<LivrosController> _logger;
    private readonly ILivrosRepositorio _livrosRepositorio;

    public LivrosController(ILogger<LivrosController> logger, ILivrosRepositorio livrosRepositorio)
    {
        _logger = logger;
        _livrosRepositorio = livrosRepositorio;
    }

    // GET .../Livros
    [HttpGet()]
    public Task<IEnumerable<Livro>> GetLivros()
    {
        return _livrosRepositorio.GetLivrosAsync();
    }


    // GET .../Livros?livroId=#
    [HttpGet("query")]
    public Task<Livro> GetLivro([FromQuery]int livroId)
    {
        return _livrosRepositorio.GetLivroAsync(livroId);
    }

}

