using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.Controllers
{
	public class AdminFeatureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
