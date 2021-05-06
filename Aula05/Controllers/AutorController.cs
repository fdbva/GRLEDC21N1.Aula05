using Aula05.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula05.Controllers
{
    public class AutorController : Controller
    {
        public IActionResult Index()
        {
            var autorModel = new AutorModel();
            autorModel.Id = 1;
            autorModel.Nome = "Felipe Andrade";

            return View(autorModel);
        }

        public IActionResult Index2()
        {
            var autorModel = new AutorModel();
            autorModel.Id = 1;
            autorModel.Nome = "Felipe Andrade";

            return View(autorModel);
        }

        public IActionResult Livro()
        {
            var autorModel = new AutorModel();
            autorModel.Id = 1;
            autorModel.Nome = "Felipe Andrade";

            return View("Index1", autorModel);
        }
    }
}
