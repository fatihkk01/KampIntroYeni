using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Buradaki T değişken oluşturulurken verilen veri tipine eşittir.
    class MyList<T>
    {
        // Diziyi newlemessek null referance hatası alırız.
        T[] items;
        //Constructor.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //items ı yeniden new lediğimizde veri kaybı olacak bunun önüne geçmek için ekleme yapmadan önceki verileri tempArray adındaki diziye atıyoruz.
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
    }
}
