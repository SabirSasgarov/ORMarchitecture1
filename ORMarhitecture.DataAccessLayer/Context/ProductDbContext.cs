using Microsoft.EntityFrameworkCore;
using ORMarhitecture.Core.Models;
using ORMarhitecture.DataAccessLayer.Configurations;


namespace ORMarhitecture.DataAccessLayer.Context
{
	public class ProductDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=SABIR\\MSSQLSERVER01;Initial Catalog=Restourant;Integrated Security=True;Trust Server Certificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductDbContext).Assembly);
			base.OnModelCreating(modelBuilder);
		}
	}
}
