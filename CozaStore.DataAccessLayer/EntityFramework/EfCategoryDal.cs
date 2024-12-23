﻿using CozaStore.DataAccessLayer.Abstract;
using CozaStore.DataAccessLayer.Context;
using CozaStore.DataAccessLayer.Repositories;
using CozaStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.DataAccessLayer.EntityFramework
{
	public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		public EfCategoryDal(CozaContext context) : base(context)
		{
		}

		public int CategoryCount()
		{
			using (var context=new CozaContext())
			{
				var values = context.Categories.Count();
				return values;
			}
		}
	}
}
