using System;
using System.Collections.Generic;

namespace Lesson9DzTwo;
class Program
{
  static void Main(string[] args)
  {
    Dictionary<string, double> products = new Dictionary<string, double>
        {
            { "Молоко", 1.99 },
            { "Хлеб", 0.99 },
            { "Курица", 3.49 },
            { "Рыба", 4.49 },
            { "Яйца кур.", 1.99 }
        };

    Console.WriteLine("Список продуктов с ценами:");
    foreach (var product in products)
    {
      Console.WriteLine($"{product.Key} - {product.Value:C2}");
    }

    Console.Write("Введите название продукта: ");
    string searchProduct = Console.ReadLine();
    if (products.ContainsKey(searchProduct))
    {
      Console.WriteLine($"Цена продукта {searchProduct}: {products[searchProduct]:C2}");
    }
    else
    {
      Console.WriteLine($"Продукт {searchProduct} отсутствует.");
    }

    Console.WriteLine("Цены после увеличения на 10%:");
    foreach (var product in products)
    {
      double newPrice = product.Value * 1.1;
      products[product.Key] = newPrice;
      Console.WriteLine($"{product.Key} - {newPrice:C2}");
      Console.ReadKey();
    }
  }
}