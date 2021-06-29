using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            //Value Types

            int number1 = 2147483647;//en büyük değer

            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = true;
            char character = 'A';
            string city = "Ankara";
            double number5 = 10.4;
            decimal number6 = 10.5m;
            var number7 = 11;
            number7 = 'A';

            Console.WriteLine("Number1 is {0}" ,number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character is : {0}", (int)character);//ASCII değeri
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }

        enum Days
        {
            Monday ,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
    }
}
