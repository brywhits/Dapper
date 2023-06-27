using System;
using System.Data;
using Dapper;
using System.Collections.Generic;

namespace Dapper
{
	public class DepartmentRepository : IDepartmentRepository
	{
		private readonly IDbConnection _connection; // Field

		//Constructor
		public DepartmentRepository(IDbConnection connection)
		{
			_connection = connection;
		}

        public IEnumerable<Department> GetALLDepartments()
        {
            //Dapper starts: Extends IDbConnection*/
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }

    }
}

