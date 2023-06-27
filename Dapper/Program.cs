using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
// Goes to appsettings file to get the connection info //
var config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

//This code finalizes it to set the connection //
string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

var repos = new DapperProductRepo(conn);

Console.WriteLine("What is the name of of your new product?");
var prodName = Console.ReadLine();

Console.WriteLine("What is the price?");
var prodPrice = double.Parse(Console.ReadLine());

Console.WriteLine("What is the CategoryID?");
var prodCat = int.Parse(Console.ReadLine());

repos.CreateProduct(prodName, prodPrice, prodCat);

var prodList = repos.GetAllProducts();

foreach (var prod in prodList)
{
    Console.WriteLine($"{prod.ProductID} - {prod.Name}");
}

Console.WriteLine("What is the ProductID you want to update?");
var prodID = int.Parse(Console.ReadLine());

Console.WriteLine("What is the new product name?");
var newName = Console.ReadLine();

repos.UpdateProduct(prodID, newName);

Console.WriteLine("What is the ProductID you want to delete?");
prodID = int.Parse(Console.ReadLine());

repos.DeleteProduct(prodID);
