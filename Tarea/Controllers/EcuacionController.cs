using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea.Controllers
{
    public class EcuacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Ecuacion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ecuacion(double a, double b, double c, double X1, double X2)
        {

            double FORMULA;

            FORMULA = b * b - 4.0 * a * c;

            X1 = (-b + Math.Sqrt(FORMULA)) / (2 * a);
            
            X2 = (-b - Math.Sqrt(FORMULA)) / (2 * a);

          
            ViewBag.Rsultado1 = X1;

            ViewBag.Rsultado2 = X2;



            return View();
        }
    }
}