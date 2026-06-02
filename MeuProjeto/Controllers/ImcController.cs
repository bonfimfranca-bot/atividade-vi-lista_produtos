using Microsoft.AspNetCore.Mvc;
using MeuProjeto.Models;

namespace MeuProjeto.Controllers
{
    public class ImcController : Controller
    {

        [HttpGet]
        public IActionResult Calcular()
        {
            return View(new ImcViewModel());
        }

        [HttpPost]
        public IActionResult Calcular(ImcViewModel model)
        {
            if (ModelState.IsValid)
            {
            
                model.ResultadoImc = model.Peso / (model.Altura * model.Altura);


                if (model.ResultadoImc < 18.5)
                    model.Classificacao = "Abaixo do peso";
                else if (model.ResultadoImc < 25)
                    model.Classificacao = "Peso normal";
                else if (model.ResultadoImc < 30)
                    model.Classificacao = "Sobrepeso";
                else
                    model.Classificacao = "Obesidade";
            }

            return View(model);
        }
    }
}