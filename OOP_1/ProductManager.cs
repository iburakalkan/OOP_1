using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class ProductManager
    {
        // void =git güncelle ,git ekle gibi emirleri yapar 
        public void Add(product product)
        {
            Console.WriteLine(product.ProductName + "eklendi");

            //product.ProductName = "kamera";
        }
        // public void BiseyYap(int sayi)
        // {
        //   sayi = 99;
        //}
        public void Update(product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{ 
        //      Console.WriteLine(sayi1+ sayi2);  
        //}



    }

}
