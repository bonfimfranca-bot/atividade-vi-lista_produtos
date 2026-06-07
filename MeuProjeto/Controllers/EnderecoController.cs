using Microsoft.AspNetCore.Mvc;
using MeuProjeto.Models;
using System.Text.Json;

namespace MeuProjeto.Controllers
{
    public class EnderecoController : Controller
    {
        [HttpGet]
        public IActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Processar([FromBody] EnderecoViewModel model)
        {
            if (model == null)
            {
                return BadRequest("Dados inválidos.");
            }

            TempData["EnderecoResultado"] = JsonSerializer.Serialize(model);

       
            return Json(new { redirectUrl = Url.Action("Resultado") });
        }

        [HttpGet]
        public IActionResult Resultado()
        {
            if (TempData["EnderecoResultado"] is string jsonString)
            {
                var model = JsonSerializer.Deserialize<EnderecoViewModel>(jsonString);
                return View(model);
            }
            return RedirectToAction("Buscar");
        }
    }
}