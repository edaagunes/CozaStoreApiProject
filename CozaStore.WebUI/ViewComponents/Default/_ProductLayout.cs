using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Default
{
	public class _ProductLayout:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
