using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeuProjeto.Controllers
{
    public class ProdutoController : Controller
    {
         
        public IActionResult Index()
        {
            
            List<string> nomes = new List<string> { "Teclado Mecânico", "Mouse Gamer", "Monitor 24'", "Cabo HDMI", "Mousepad" };

            
            List<double> precos = new List<double> { 250.00, 89.90, 899.00, 45.00, 120.00 };

            
            ViewBag.ListaNomes = nomes;
            ViewBag.ListaPrecos = precos;

            
            return View();
        }
    }
}