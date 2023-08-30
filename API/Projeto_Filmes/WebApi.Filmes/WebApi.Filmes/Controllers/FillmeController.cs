using Microsoft.AspNetCore.Mvc;

namespace WebApi.Filmes.Controllers
{
    public class FillmeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
