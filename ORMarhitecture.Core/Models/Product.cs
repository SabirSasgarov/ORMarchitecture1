using ORMarhitecture.Core.Models.Common;

namespace ORMarhitecture.Core.Models
{
	public class Product : AuditableEntity
	{
		//[Required]
		//[MaxLength(15)]
		public string Name { get; set; } = null!;
		//[Required]
		//[MaxLength(100)]
		public string Description { get; set; } = null!;
		public decimal Price { get; set; }
		//public bool IsDeleted { get; set; } = false;
		public Guid CategoryId {  get; set; }
		public Category Category { get; set; }

		public override string ToString()
		{
			return $"Product name - {Name}, description - {Description}, price - {Price}";
		}
	}
}
