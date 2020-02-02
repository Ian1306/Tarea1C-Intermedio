using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea.Controllers
{
    public class MultiplicarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Multiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Multiplicar( int Num1, int Resultado)
        {


            for (int i = 1; i >= 12; i++)
            {

                Resultado = Num1 * i;
                ViewBag.ResulMultip = Resultado;

            }

           


            return View();
        }

    }
}