using CozaStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.DataAccessLayer.Abstract
{
	public interface IProductDal : IGenericDal<Product>
	{
		int ProductCount();
		Product GetLastProduct();

		List<Product> GetLast4Products();
	}
}
