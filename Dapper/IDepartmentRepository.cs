using System;
using System.Collections.Generic;

namespace Dapper
{
	public interface IDepartmentRepository
	{
		public IEnumerable<Department> GetALLDepartments();
	}
}

