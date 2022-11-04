using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		public IActionResult Index()
		{
			var customers1 = new List<Customers>()
			{
				new Customers = { Id=1, Name = "John Smith" },
				new Customers = { Id=2, Name = "Mary Williams" }
			};
			RandomMovieViewModel viewModel = new RandomMovieViewModel();
			{
				Customers = customers1,
			};

			return View(viewModel);
		}
	}
}
