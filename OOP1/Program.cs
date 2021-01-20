using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            //intentional programing nedir araştır.

            //1.YOL
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //2.YOL
            Product product2 = new Product { Id = 2,
                CategoryId = 5, UnitsInStock = 5, 
                ProductName = "Kalem", UnitPrice = 35};
            //PascalCase   //camelCase
            //case sensitive
            //Stack                         //Heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int,double,bool...değer tip
            //diziler,class,abstract class,interface...referans tip
            //ref out

        }
    }
}
