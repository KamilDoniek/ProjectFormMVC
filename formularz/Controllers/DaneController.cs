using formularz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace formularz.Controllers
{
    public class DaneController : Controller
    {
    
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            return ModelState.IsValid ? View("Wynik", dane) : View();
        }
        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}