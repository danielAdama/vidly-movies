using Microsoft.AspNetCore.Mvc;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
