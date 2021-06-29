using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
            new Customer{
                FirstName="Büşra",LastName="Muslu"
            },
            new Student{
                FirstName="Nur"
            },
            new Person{
                FirstName="Salih"
            }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }


        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class person2
        {

        }
        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
