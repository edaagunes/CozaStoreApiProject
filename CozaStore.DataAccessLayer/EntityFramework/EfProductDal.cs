﻿using CozaStore.DataAccessLayer.Abstract;
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

	}
}

