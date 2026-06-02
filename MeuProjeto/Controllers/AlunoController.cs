using Microsoft.AspNetCore.Mvc;
using MeuProjeto.Models;

namespace MeuProjeto.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
           
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Confirmacao", aluno);
                
            }

            return View(aluno);
        }
        
        [HttpGet]
        public IActionResult Confirmacao(Aluno aluno)
        {
            return View(aluno); 
        }
    }
}