using CozaStore.BusinessLayer.Abstract;
using CozaStore.DataAccessLayer.Abstract;
using CozaStore.DataAccessLayer.EntityFramework;
using CozaStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void TDelete(int id)
		{
			_productDal.Delete(id);
		}

		public List<Product> TGetAll()
		{
			return _productDal.GetAll();
		}

		public Product TGetById(int id)
		{
			return _productDal.GetById(id);
		}

		public void TInsert(Product entity)
		{
			_productDal.Insert(entity);
		}

		public void TUpdate(Product entity)
		{
			_productDal.Update(entity);
		}
	}
}
