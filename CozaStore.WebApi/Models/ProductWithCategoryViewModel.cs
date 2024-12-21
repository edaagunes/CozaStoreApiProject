namespace CozaStore.WebApi.Models
{
	public class ProductWithCategoryViewModel
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int Price { get; set; }
		public string Detail { get; set; }
		public string ImageUrl { get; set; }
		public string CategoryName { get; set; }
		public int CategoryId { get; set; }
	}
}
