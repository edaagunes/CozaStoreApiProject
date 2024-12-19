using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Default
{
	public class _HeaderLayout : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
