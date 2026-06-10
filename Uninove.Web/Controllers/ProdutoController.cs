using Microsoft.AspNetCore.Mvc;

namespace Uninove.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Produtos = new List<string>
            {
                "Notebook",
                "Mouse",
                "Teclado",
                "Monitor",
                "Headset"
            };

            ViewBag.Precos = new List<double>
            {
                3500,
                50,
                120,
                900,
                80
            };

            return View();
        }
    }
}