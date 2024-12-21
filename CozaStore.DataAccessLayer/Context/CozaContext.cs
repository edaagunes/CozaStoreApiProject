using CozaStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.DataAccessLayer.Context
{
	public class CozaContext : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-3OD251U\\SQLEXPRESS; initial catalog=CozaStoreApiDb;integrated security=true;");
		}
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
	}
}
