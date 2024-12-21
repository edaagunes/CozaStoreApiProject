using CozaStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.BusinessLayer.Abstract
{
	public interface IProductService : IGenericService<Product>
	{
		int TProductCount();
		Product TGetLastProduct();
		List<Product> TGetLast4Products();
	}
}
