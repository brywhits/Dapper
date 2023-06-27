using System;
using System.Data;
using Dapper;

namespace Dapper
{
	public class DapperProductRepository 
	{
		private readonly IDbConnection _connection;

		public DapperProductRepository(IDbConnection connection)
		{
			_connection = connection;
		}

        public IEnumerable<Product> GetAllProducts()
        {
			//Dapper starts: Extends IDbConnection*/
			return _connection.Query<Product>("SELECT * FROM PRODUCTS;");
		}

        
    }
}

