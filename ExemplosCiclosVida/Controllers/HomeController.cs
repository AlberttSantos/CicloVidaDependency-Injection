using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExemplosCiclosVida.Models;

namespace ExemplosCiclosVida.Controllers
{
    public class HomeController : Controller
    {
        public static int Count { get; set; }

        public readonly IRenderSingleton Singleton0;
        public readonly IRenderSingleton Singleton1;

        public readonly IRenderScoped Scope0;
        public readonly IRenderScoped Scope1;

        public readonly IRenderTransient Transient0;
        public readonly IRenderTransient Transient1;

        public HomeController(
            IRenderScoped scope0,
            IRenderScoped scope1,
            IRenderSingleton singleton0,
            IRenderSingleton singleton1,
            IRenderTransient transient0,
            IRenderTransient transient1
            )
        {
            Scope0 = scope0;
            Scope1 = scope1;
            Singleton0 = singleton0;
            Singleton1 = singleton1;
            Transient0 = transient0;
            Transient1 = transient1;
        }

        public IActionResult Index()
        {
            ViewBag.Scopes = new string[2]
            {
                Scope0.GetGuidNow.ToString(),
                Scope1.GetGuidNow.ToString()
            };

            ViewBag.Transients = new string[2]
            {
                Transient0.GetGuidNow.ToString(),
                Transient1.GetGuidNow.ToString()
            };

            ViewBag.Singletons = new string[2]
            {
                Singleton0.GetGuidNow.ToString(),
                Singleton1.GetGuidNow.ToString()
            };

            Count++;
            ViewBag.Count = Count;
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
