using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeuProjeto.Models;

namespace MeuProjeto.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
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
    public IActionResult Boletim()
    {
        List<string> disciplinas = new List<string> { "Matemática", "Programação Web", "Banco de Dados", "Estrutura de Dados", "Redes" };
        List<double> notas = new List<double> { 9.5, 8.0, 6.2, 4.5, 7.0 };

        ViewBag.Disciplinas = disciplinas;
        ViewBag.Notas = notas;

        return View();
    }
};
