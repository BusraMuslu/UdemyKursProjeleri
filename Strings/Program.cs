using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is BÜşra Nur Muslu";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence= "My name is BÜşra Nur Muslu";

            bool result3 = sentence.EndsWith("ğ");//CÜmle ğ ile bitiyor mu diye kontrol eder
            bool resul4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name");//Belli bir karajteri ve ya ifadeyi aramak için kullanılır.
            var result6= sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello");//Bir ifade yerleştirmek için kulanılır.
            var result9 = sentence.Substring(3,4);//Cümleyi parçalamak için kullanılır
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2,4);//Bir metinden belirli bir indeks ten sonrasını atmak için kullanılır.
            Console.WriteLine(result13);
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            //string result = city + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            //Console.WriteLine(result);
        }
    }
}
