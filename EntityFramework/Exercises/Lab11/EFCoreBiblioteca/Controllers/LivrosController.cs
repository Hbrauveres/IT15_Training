using Microsoft.AspNetCore.Mvc;
using EFCoreBiblioteca.Services;
using EFCoreBiblioteca.Services.Interfaces;
using EFCoreBiblioteca.Models;

namespace EFCoreBiblioteca.Controllers;

[ApiController]
[Route("[controller]")]
public class LivrosController : ControllerBase
{
    private readonly ILogger<LivrosController> _logger;
    private readonly ILivrosRepositorio _livrosRepositorio;
    private readonly IAutoresRepositorio _autoresRepositorio;

    public LivrosController(ILogger<LivrosController> logger, ILivrosRepositorio livrosRepositorio, IAutoresRepositorio autoresRepositorio)
    {
        _logger = logger;
        _livrosRepositorio = livrosRepositorio;
        _autoresRepositorio = autoresRepositorio;
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

    [HttpGet("{autorId}")]
    public async Task<ActionResult<AutorLivrosDTO>> GetLivrosByAutor(int autorId)
    {
        Console.WriteLine($"Entrou no lugar certo. AutorId = {autorId}");
        if (autorId <= 0)
        {
            Console.WriteLine($"AutorId = {autorId}");
            return BadRequest();
        }
    
        Autor? autor = await _autoresRepositorio.GetAutorAsync(autorId);
        if (autor == null)
        {
            Console.WriteLine($"AutorId = {autorId}");
            return NotFound();
        }
        
        // Criar um objeto dto AutorLivrosDTO
        AutorLivrosDTO AutorLivros = new AutorLivrosDTO(); 
        // AutorLivrosDTO.AutorId = autorId
        AutorLivros.AutorId = autorId;
        // Pega todos livros em que esse autor é autor
        AutorLivros.Livros = await _livrosRepositorio.GetLivrosByAutorAsync(autorId);
        //var Livros = await _livrosRepositorio.GetLivrosByAutorAsync(autorId);
        // Cria uma lista de LivroEmprestimoDTO
        // Verifica se o livro tem emprestimo = true/false
        // Se livro está emprestado
            // Cria objeto LivroEmprestimoDTO com data de entrega
        // Se livro não está emprestado
            // Cria objeto LivroEmprestimoDTO sem data de entrega
        // retornar AutorLivrosDTO
        return AutorLivros;
    }
}

