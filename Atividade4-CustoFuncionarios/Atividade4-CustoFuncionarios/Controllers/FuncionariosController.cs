using Atividade4_CustoFuncionarios.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividade4_CustoFuncionarios.Controllers
{
    public class FuncionariosController : Controller
    {
        [HttpGet]
        public IActionResult Calculadora() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult Resultado() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calcular(FuncionarioModel funcionario)
        {
            if (ModelState.IsValid)
            {
                var custoTotal = funcionario.CalcCT();
                ViewBag.CustoTotal = custoTotal;
                return View("Resultado");
            }
            return View("Calculadora");
        }
    }
}
