using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Default
{
	public class _HeadLayout : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
