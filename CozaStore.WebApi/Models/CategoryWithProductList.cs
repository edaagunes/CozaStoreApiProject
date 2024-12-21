using CozaStore.EntityLayer.Concrete;

namespace CozaStore.WebApi.Models
{
	public class CategoryWithProductList
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string Title { get; set; }
		public string ImageUrl { get; set; }
		public List<Product> Products { get; set; }
		

	}
}
