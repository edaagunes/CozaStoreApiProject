using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
