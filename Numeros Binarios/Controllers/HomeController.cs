using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Numeros_Binarios.Models;

namespace Numeros_Binarios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Data numero)
        {
            if (ModelState.IsValid)
            {
                int _numero1 = numero.number1; int _numero4 = numero.number4; int _numero7 = numero.number7;
                int _numero2 = numero.number2; int _numero5 = numero.number5; int _numero8 = numero.number8;
                int _numero3 = numero.number3; int _numero6 = numero.number6; int _numero9 = numero.number9;
                int _numero10 = numero.number10;
                int[] numericos = new int[10];
                numericos = new int[10] { _numero1, _numero2, _numero3, _numero4, _numero5, _numero6, _numero7, _numero8, _numero9, _numero10 };
               
                for(int i=0;i <= 9; i++)
                {
                    if (numericos[i] <= 1)
                    {
                        ViewData["num" + i] = "000" + Convert.ToString(numericos[i],2).ToString();
                        ViewData["numIngresado" + i] = numericos[i];
                    }
                    else if((numericos[i] > 1)&& (numericos[i] <= 3))
                    {
                        ViewData["num" + i] = "00" + Convert.ToString(numericos[i], 2).ToString();
                        ViewData["numIngresado" + i] = numericos[i];
                    }
                    else if ((numericos[i] > 3) && (numericos[i] <= 7))
                    {
                        ViewData["num" + i] = "0" + Convert.ToString(numericos[i], 2).ToString();
                        ViewData["numIngresado" + i] = numericos[i];
                    }
                    else
                    {
                        ViewData["num" + i] = Convert.ToString(numericos[i], 2).ToString();
                        ViewData["numIngresado" + i] = numericos[i];
                    }
                }

            }

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
