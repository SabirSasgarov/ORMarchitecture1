using Microsoft.EntityFrameworkCore;
using ORMarhitecture.Core.Models;


namespace ORMarhitecture.DataAccessLayer.Context
{
	public class ProductDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=SABIR\\MSSQLSERVER01;Initial Catalog=Restourant;Integrated Security=True;Trust Server Certificate=True;");
		}
	}
}
