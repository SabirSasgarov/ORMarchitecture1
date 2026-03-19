using ORMarhitecture.Core.Models.Common;
using System.ComponentModel.DataAnnotations;

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

		public override string ToString()
		{
			return $"Product name - {Name}, description - {Description}, price - {Price}";
		}
	}
}
