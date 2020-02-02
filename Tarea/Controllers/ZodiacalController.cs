using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea.Controllers
{
    public class ZodiacalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




        [HttpGet]
        public IActionResult Zodiacal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Zodiacal(DateTime fecha)
        {
            var mes = fecha.Month;
            var Dia = fecha.Day;


            switch (mes)
            {
                case 1:
                    if (fecha.Day <= 19)
                    {

                        ViewBag.fecha = "Capricornio";

                    }
                    else
                        ViewBag.fecha = "acuario";

                    break;
                case 2:
                    if (fecha.Day <= 18 )
                    {

                        ViewBag.fecha = "acuario";

                    }
                    else
                        ViewBag.fecha = "Pesis";

                    break;

                case 3:
                    if (fecha.Day <= 20)
                    {

                        ViewBag.fecha = "Pisis";

                    }
                    else
                        ViewBag.fecha = "Aries";

                    break;

                case 4:
                    if (fecha.Day <= 19)
                    {

                        ViewBag.fecha = "Aries";

                    }
                    else
                        ViewBag.fecha = "Tauro";

                    break;

                case 5:
                    if (fecha.Day <= 20)
                    {

                        ViewBag.fecha = "Tauro";

                    }
                    else
                        ViewBag.fecha = "Geminis";

                    break;
                case 6:
                    if (fecha.Day <= 20)
                    {

                        ViewBag.fecha = "Geminis";

                    }
                    else
                        ViewBag.fecha = "Cancer";

                    break;
                case 7:
                    if (fecha.Day <= 22)
                    {

                        ViewBag.fecha = "Cancer";

                    }
                    else
                        ViewBag.fecha = "Leo";

                    break;
                case 8:
                    if (fecha.Day <= 22)
                    {

                        ViewBag.fecha = "Leo";

                    }
                    else
                        ViewBag.fecha = "Virgo";

                    break;
                case 9:
                    if (fecha.Day <= 23)
                    {

                        ViewBag.fecha = "Virgo";

                    }
                    else
                        ViewBag.fecha = "Libra";

                    break;
                case 10:
                    if (fecha.Day <= 22)
                    {

                        ViewBag.fecha = "Libra";

                    }
                    else
                        ViewBag.fecha = "Scorpion";

                    break;
                case 11:
                    if (fecha.Day <= 23)
                    {

                        ViewBag.fecha = "Scorpion";

                    }
                    else
                        ViewBag.fecha = "Sagitario";

                    break;
                case 12:
                    if (fecha.Day <= 21)
                    {

                        ViewBag.fecha = "Sagitario";

                    }
                    else
                        ViewBag.fecha = "Capricornio";

                    break;
            }
            
            
           

            return View();

        }



    }
}