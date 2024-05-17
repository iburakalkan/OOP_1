using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.Id = 1;
            product1.CatergoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            product product2 = new product { Id = 2, CatergoryId = 5, UnitsInStock = 5,
                ProductName = "kalem",UnitPrice=35};
            // case sensitive
            //PascalCase  //camelCase

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            ////int  sayi = 100;
            ////productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);
            





        }
    }
}
