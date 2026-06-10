using Microsoft.AspNetCore.Mvc;

namespace BoletimMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Boletim");
    }

    public IActionResult Boletim()
    {
        ViewBag.Disciplinas = new List<string>
        {
            "Matemática",
            "Português",
            "História",
            "Geografia",
            "Programação"
        };

        ViewBag.Notas = new List<double>
        {
            9.5,
            8.0,
            6.5,
            4.0,
            10.0
        };

        return View();
    }
}