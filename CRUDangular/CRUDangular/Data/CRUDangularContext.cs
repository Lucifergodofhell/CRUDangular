using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDangular.Model;

namespace CRUDangular.Models
{
	public class CRUDangularContext : DbContext
	{
		public CRUDangularContext(DbContextOptions<CRUDangularContext> options)
			: base(options)
		{
		}

		public DbSet<User> User { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<User>().HasKey(entity => entity.Id);
			builder.Entity<User>().Property(entity => entity.Id).ValueGeneratedOnAdd();
		}
	}
}
