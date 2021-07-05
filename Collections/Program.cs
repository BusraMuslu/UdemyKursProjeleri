using System;
using System.Collections;
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
            //string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities.Add yeni bir şey eklemek isteiğimizde böyl bir method yoktur
            // cities[2] = "Adana"; //Bu şekilde yazıldığından dizi sınırını aşarsın..

            //cities = new string[3];//Yeni bir referans atadık onunda içi boş..
            //Console.WriteLine(cities[0]);//Console da bir şey yazmadı çünkü biz new lediğimiz anda ilk tanımladığımız değer uçar..
            //Arraylist();

            //TİP GÜVENLİ KOLEKSİYONLAR
           //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

           // Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);
            foreach (var item in dictionary)
            {
                Console.WriteLine("Key :"+item.Key);
                Console.WriteLine("Value :" + item.Value);
            }
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

        }

        private static void List()
        {
            List<string> cities = new List<string>();//Ben bir koleksiyon oluşturmak istiyorum ve ben bu koleksiyonda sadece ve sadece string ile çalışabilirim.
            cities.Add("Ankara");
            cities.Add("İstanbul");
            Console.WriteLine(cities.Contains("Ankara"));//şehirlerin içinde ankara değeri varsa true ver
            //cities.Add(1);//Sadece string  olduğu için 1 değerini yazamam.

            foreach (var city2 in cities)
            {
                Console.WriteLine(city2);
            }
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Büşra" });
            //customers.Add(new Customer { Id = 2, FirstName = "Nur" });

            List<Customer> customers = new List<Customer> {

                new Customer { Id = 1, FirstName = "Büşra" },
                new Customer { Id = 2, FirstName = "Nur" }
            };


            //Console.WriteLine("Count :" + count);
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Muslu"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2] {
                new Customer{Id = 4, FirstName = "Ali"},
                new Customer{Id = 5, FirstName = "Ayşe"}
            });
            //Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Büşra" }));//False döner. New dediğimiz zaman yeni bir referans vermiş oluruz.
            Console.WriteLine(customers.Contains(customer2));
            //customers.Clear();
            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index : {0}", index);

            customers.Add(customer2);
            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Index : {0}", index2);

            customers.Insert(0, customer2);//Kaçıncı sıraya neyi eklemek istiyorsun..

            //customers.Remove(customer2);//İlk bulduğu elemanı siler..
            //customers.Remove(customer2);
            //customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Muslu");

            foreach (var customer in customers)
            {
                //Console.WriteLine(customer);//Collections.Customer çıktıı
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count();
            Console.WriteLine("Count : {0}", count);
            //Console.WriteLine(cities[2]);
        }

        private static void Arraylist()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
