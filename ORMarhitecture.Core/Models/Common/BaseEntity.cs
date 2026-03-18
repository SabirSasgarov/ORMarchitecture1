using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		//public bool IsDeleted { get; set; } = false;
		//public DateTime? DeleteTime { get; set; }

	}

}
