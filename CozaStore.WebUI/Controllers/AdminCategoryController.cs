using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.Controllers
{
	public class AdminCategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
