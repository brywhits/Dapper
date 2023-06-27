﻿using System;
namespace Dapper
{ 
	public class Product
	{
		//each column from the products table will be a property
		public int ProductID { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public int CategoryID { get; set; }
		public int OnSale { get; set; }
		public string StockLevel { get; set; }
	}
	
}

