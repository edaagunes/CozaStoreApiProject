using CozaStore.EntityLayer.Concrete;
using CozaStore.WebUI.Dtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CozaStore.WebUI.ViewComponents.Dashboard
{
	public class _StatisticsDashboard:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _StatisticsDashboard(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();

			var responseMessage = await client.GetAsync("https://localhost:7043/api/Category/CategoryCount");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var categoryCount = JsonConvert.DeserializeObject<int>(jsonData);
				ViewBag.CategoryCount = categoryCount;
			}

			var responseMessage2 = await client.GetAsync("https://localhost:7043/api/Product/ProductCount");
			if (responseMessage2.IsSuccessStatusCode)
			{
				var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
				var productCount = JsonConvert.DeserializeObject<int>(jsonData2);
				ViewBag.ProductCount = productCount;
			}

			var responseMessage3 = await client.GetAsync("https://localhost:7043/api/Product/LastProduct");
			if (responseMessage3.IsSuccessStatusCode)
			{
				var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
				var lastProduct = JsonConvert.DeserializeObject<Product>(jsonData3);
				ViewBag.LastProduct = lastProduct.ProductName;
				ViewBag.LastProductImage = lastProduct.ImageUrl;
			}

			var responseMessage4 = await client.GetAsync("https://localhost:7043/api/Contact/LastMessage");
			if (responseMessage4.IsSuccessStatusCode)
			{
				var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
				var lastMessage = JsonConvert.DeserializeObject<Contact>(jsonData4);
				ViewBag.LastMessageMail = lastMessage.SenderMail;
				ViewBag.LastMessage = lastMessage.Message;
			}
			return View();
		}
	}
}
