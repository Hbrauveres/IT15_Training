using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCCep.Models;
using MVCCep.Services;

namespace MVCCep.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICepService _cepservice;
    
    // Injeção de dependencias
    public HomeController(ILogger<HomeController> logger, ICepService cepService)
    {
        _logger = logger;
        _cepservice = cepService;
    }

    public IActionResult Index()
    {
        var ceps = _cepservice.ConsultaTodos();
        return View(ceps);
    }

    public IActionResult Create() // GET .../Home/Create
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Cep,Logradouro,Bairro,Cidade,Estado")]ConsultaCep novoCep) // POST .../Home/Create
    {
        if(ModelState.IsValid)
        {
            _cepservice.Cadastrar(novoCep);
            return RedirectToAction(nameof(Index));
        }
        return View();
    }

    public IActionResult Search(string id)
    {
        ViewData["Id"] = id;
        ConsultaCep? resultado = null;
        if (!String.IsNullOrEmpty(id))
        {
            resultado = _cepservice.ConsutaPorCep(id);
        }
        return View(resultado);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
