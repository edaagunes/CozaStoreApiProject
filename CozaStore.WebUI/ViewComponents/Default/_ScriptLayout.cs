using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Default
{
	public class _ScriptLayout:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
