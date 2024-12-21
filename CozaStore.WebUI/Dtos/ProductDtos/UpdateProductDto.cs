﻿using CozaStore.EntityLayer.Concrete;

namespace CozaStore.WebUI.Dtos.ProductDtos
{
	public class UpdateProductDto
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int Price { get; set; }
		public string Detail { get; set; }
		public string ImageUrl { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
