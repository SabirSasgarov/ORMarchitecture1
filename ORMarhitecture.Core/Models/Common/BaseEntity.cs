namespace ORMarhitecture.Core.Models.Common
{
	public abstract class BaseEntity
	{
		public Guid Id { get; set; }
	}

	public class AuditableEntity : BaseEntity
	{
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool IsDeleted { get; set; } = false;
		public DateTime? DeleteTime { get; set; }

	}

}
