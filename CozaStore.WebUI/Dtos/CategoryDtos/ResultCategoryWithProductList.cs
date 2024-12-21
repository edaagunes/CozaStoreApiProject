using CozaStore.EntityLayer.Concrete;

namespace CozaStore.WebUI.Dtos.CategoryDtos
{
	public class ResultCategoryWithProductList
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string Title { get; set; }
		public string ImageUrl { get; set; }
		public List<Product> Products { get; set; }

	}
}
