using CozaStore.WebUI.Dtos.FeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CozaStore.WebUI.ViewComponents.Default
{
	public class _SliderLayout : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _SliderLayout(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();

			var responseMessage = await client.GetAsync("https://localhost:7043/api/Feature");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
