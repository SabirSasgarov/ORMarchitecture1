using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORMarhitecture.Core.Models;

namespace ORMarhitecture.DataAccessLayer.Configurations
{
	internal class CategoryConfig : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.ToTable("Categories");

			builder.HasKey(c => c.Id);

			builder.Property(c => c.Id)
				.HasDefaultValueSql("NEWSEQUENTIALID()");

			builder
				.Property(c => c.Name)
				.IsRequired()
				.HasMaxLength(15);

			builder
				.Property(c => c.Description)
				.IsRequired()
				.HasMaxLength(100);

			builder
				.Property(c => c.Limit)
				.HasMaxLength(10000);

			builder
				.Property(c => c.CreatedDate)
				.IsRequired()
				.HasDefaultValue(DateTime.Now);

			builder
				.HasMany(c => c.Products)
				.WithOne(p => p.Category)
				.HasForeignKey(p => p.CategoryId);

			SeedCategory.SeedCat(builder);
		}
	}
}
