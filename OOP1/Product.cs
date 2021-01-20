using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet (tab + tab)
    //Product = Urun 
    //ProductName = UrunAdi 
    //UnitPrice = UrunFiyati 
    //Kod okunurluğu için foreign key ile sınıfın ıd si alt alta yazılır.
    //CRUD (Create - Read - Update - Delete)
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        



    }
}
