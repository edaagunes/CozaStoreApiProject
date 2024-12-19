using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Default
{
	public class _FooterLayout:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
