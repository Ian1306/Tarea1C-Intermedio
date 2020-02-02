using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea.Controllers
{
    public class ListaPersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TablaGeneral()
        {
            return View();
        }


    }
}