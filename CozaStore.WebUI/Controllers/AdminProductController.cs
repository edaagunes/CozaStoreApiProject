using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.Controllers
{
	public class AdminProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
