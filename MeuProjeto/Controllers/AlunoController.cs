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
                
                ViewBag.MensagemSucesso = "Aluno cadastrado com sucesso e sem erros!";
                
               
                return View();
            }

            return View(aluno);
        }
    }
}