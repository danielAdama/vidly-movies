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
            return View(movie);
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
            return Content($"id= {id}");
        }

        [HttpGet]
        public IActionResult Index(int? pageIndex, string sortBy) 
        {
            //if pageIndex is not specified we display the movies in page 1, likewise sortBy we sort by their names
            if (!pageIndex.HasValue) 
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy)) 
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public IActionResult ByReleaseDate(int year, int month) 
        {
            return Content(year + "/" + month);
        }
    }
}
