using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TYL_LASEC.Models;

namespace TYL_LASEC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Mensaje = "mensaje";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
        public int iniciar()
        {
            
            tortuga T = new tortuga();
            liebre L = new liebre();

            Thread tortuga = new Thread(T.tortugarun);
            Thread liebre = new Thread(L.liebrerun);
            tortuga.Priority = ThreadPriority.Highest;
            liebre.Priority = ThreadPriority.Highest;
            
            tortuga.Start();
            liebre.Start();
            
            return T.posicion +L.posicion;
          
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
