using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.Controllers
{
	public class FeatureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
