using MeuPimAutomacaoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPimAutomacaoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            HomeModel home = new HomeModel();

            home.Nome = "Bruna dos Santos Albuquerque";
            home.Email = "albuquerquebruna110902@gmail.com";

            return View(home);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
