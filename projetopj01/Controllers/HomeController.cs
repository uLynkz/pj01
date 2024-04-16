using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projetopj01.Models;

namespace projetopj01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        try{
            TempData["Sucesso"]="Cadastrado com sucesso!";
        }
        catch{
            TempData["Erro"]="Erro na execução do sistema";
        }
        TempData["Erro"]="erro na execução do sistema";
        return View();
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
