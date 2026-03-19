using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Identity.Client;
using ORMarhitecture.Core.Models;
using ORMarhitecture.DataAccessLayer.Context;

namespace ORMarhitecture.BLogicLayer.Services
{
	public class ProductService(ProductDbContext context)
	{
		public async Task<List<Product>> GetAllProducts()
			=> await context.Products
			.AsNoTracking()
			.ToListAsync();

		public async Task<Product> GetProductById(Guid id)
		{
			var existingProduct = await context.Products
				.AsNoTracking()
				.FirstOrDefaultAsync(p => p.Id == id);
			if (existingProduct == null)
				throw new Exception($"Not found!");

			return existingProduct;
		}

		public async Task<List<Product>> GetSearchedProducts(string searchStr)
		{
			if (string.IsNullOrWhiteSpace(searchStr))
				throw new Exception("Enter something to search?");
			return await context.Products
				.AsNoTracking()
				.Where(p => p.Name.Contains(searchStr) || p.Description.Contains(searchStr))
				.ToListAsync();
		}

		public async Task<Product> AddProduct(Product newProduct)
		{
			if(newProduct == null)
				throw new Exception("Product is null!");

			if (await context.Products.AnyAsync(p => p.Name.ToLower() == newProduct.Name.ToLower()))
				throw new Exception("Already exists!");
			newProduct.Id = Guid.NewGuid();
			newProduct.CreatedDate = DateTime.Now;
			await context.Products.AddAsync(newProduct);
			await context.SaveChangesAsync();
			return newProduct;
		}




	}
}
