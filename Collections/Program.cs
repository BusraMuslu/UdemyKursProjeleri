using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities.Add yeni bir şey eklemek isteiğimizde böyl bir method yoktur
            // cities[2] = "Adana"; //Bu şekilde yazıldığından dizi sınırını aşarsın..

            cities = new string[3];
            Console.WriteLine(cities[0]);//Console da bir şey yazmadı çünkü biz new lediğimiz anda ilk tanımladığımız değer uçar..

        }
    }
}
