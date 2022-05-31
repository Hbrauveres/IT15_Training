using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCIntroducao.Models;

namespace MVCIntroducao.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public string AloMundo(string name) // .../Home/AloMundo?name=Henrique
    {
        return $"Alo, {name}"; // FURO DE SEGURANÇA!!!!!!!!!
                               // Recebendo valor nao verificado para execução
    }

    public IActionResult Index() // .../Home/Index ou /
    {
        return View();
    }

    public IActionResult Privacy() // .../Home/Privacy
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() // .../Home/Error
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
