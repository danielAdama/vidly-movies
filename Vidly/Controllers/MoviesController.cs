using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        [HttpGet]
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            return View();
        }
    }
}
