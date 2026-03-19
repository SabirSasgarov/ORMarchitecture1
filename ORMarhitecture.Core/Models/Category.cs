using ORMarhitecture.Core.Models.Common;

namespace ORMarhitecture.Core.Models
{
	public class Category : AuditableEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int Limit { get; set; }
		public List<Product> Products { get; set; }
	}
}
