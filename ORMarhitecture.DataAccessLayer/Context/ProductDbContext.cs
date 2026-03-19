using Microsoft.EntityFrameworkCore;
using ORMarhitecture.Core.Models;
using ORMarhitecture.Core.Models.Common;


namespace ORMarhitecture.DataAccessLayer.Context
{
	public class ProductDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }

		public DbSet<Category> Categories { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=SABIR\\MSSQLSERVER01;Initial Catalog=Restourant;Integrated Security=True;Trust Server Certificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductDbContext).Assembly);
			base.OnModelCreating(modelBuilder);
		}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			var entries = ChangeTracker.Entries<AuditableEntity>().ToList();
			foreach (var entry in entries)
			{
				switch (entry.State)
				{
					case EntityState.Added:
						entry.Entity.CreatedDate = DateTime.Now;
						break;
					case EntityState.Modified:
						if(entry.Entity.IsDeleted == true)
							entry.Entity.DeleteTime = DateTime.Now;
						else
							entry.Entity.UpdatedDate = DateTime.Now;
						break;
					default:
						break;
				}
			}

			return base.SaveChangesAsync(cancellationToken);
		}

	}
}
