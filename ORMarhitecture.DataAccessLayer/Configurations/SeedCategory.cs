using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORMarhitecture.Core.Models;

namespace ORMarhitecture.DataAccessLayer.Configurations
{
	public class SeedCategory 
	{
		public static void SeedCat(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(
				new Category
				{
					Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
					Name = "Drinks",
					Description = "Cold and hot beverages",
					Limit = 1,
					CreatedDate = new DateTime(2024, 1, 1),
					IsDeleted = false
				},
				new Category
				{
					Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
					Name = "Meals",
					Description = "Main course dishes",
					Limit = 2,
					CreatedDate = new DateTime(2024, 1, 1),
					IsDeleted = false
				},
				new Category
				{
					Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
					Name = "Desserts",
					Description = "Sweet dishes and cakes",
					Limit = 15,
					CreatedDate = new DateTime(2024, 1, 1),
					IsDeleted = false
				},
				new Category
				{
					Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
					Name = "Salads",
					Description = "Fresh salads and appetizers",
					Limit = 12,
					CreatedDate = new DateTime(2024, 1, 1),
					IsDeleted = false
				},
				new Category
				{
					Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
					Name = "Soups",
					Description = "Hot and cold soups",
					Limit = 10,
					CreatedDate = new DateTime(2024, 1, 1),
					IsDeleted = false
				}
			);
		}
	}
}
