using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
