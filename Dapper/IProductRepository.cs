﻿using System;
using System.Collections.Generic;

namespace Dapper
{
	public interface IProductRepository
	{
        IEnumerable<Product> GetAllProducts();
        
        public void CreateProduct(string name, double price, int categoryID);

        public void UpdateProduct(int productID, string updatedName);

        public void DeleteProduct(int productID);
    }
}

