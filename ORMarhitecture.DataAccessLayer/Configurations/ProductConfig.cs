using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORMarhitecture.Core.Models;


namespace ORMarhitecture.DataAccessLayer.Configurations
{
	internal class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.Property<int>("Id");
			builder.Property<int>("Id");
				
		}
	}
}
