using AracKiralama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AracKiralama.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home() { 
            return View(); 
        }
    }
}