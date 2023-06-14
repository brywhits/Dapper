using System;
namespace Dapper
{
	public interface IDepartmentRepository
	{
		public IEnumerable<Department> GetALLDepartments();

		public void InsertDepartment(string newDepartmentName);
	}
}

