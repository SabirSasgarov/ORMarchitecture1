using ORMarhitecture.Core.Models.Common;

namespace ORMarhitecture.Core.Models
{
	public class Product : AuditableEntity
	{
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public decimal Price { get; set; }

		public override string ToString()
		{
			return $"Product name - {Name}, description - {Description}, price - {Price}";
		}
	}
}
