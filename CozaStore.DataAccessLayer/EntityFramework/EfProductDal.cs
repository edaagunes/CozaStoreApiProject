using CozaStore.DataAccessLayer.Abstract;
using CozaStore.DataAccessLayer.Context;
using CozaStore.DataAccessLayer.Repositories;
using CozaStore.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.DataAccessLayer.EntityFramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public EfProductDal(CozaContext context) : base(context)
		{
		}

		public List<Product> GetLast4Products()
		{
			using (var context = new CozaContext())
			{
				var last4Product = context.Products
										 .OrderByDescending(p => p.ProductId)
										 .Take(4).ToList();
				return last4Product;
			}
		}

		public Product GetLastProduct()
		{
			using (var context = new CozaContext())
			{
				var lastProduct = context.Products
										 .OrderByDescending(p => p.ProductId) 
										 .FirstOrDefault(); 
				return lastProduct;
			}
		}


		public int ProductCount()
		{
			using (var context=new CozaContext())
			{
				var values = context.Products.Count();
				return values;
			}
		}
	}
}

