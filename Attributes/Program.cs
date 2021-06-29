using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Muslu", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }

    [ToTable("Customers")]//Bunun anlamı bu customer nesnesi veri tabanlarına customers tablosuna denk gelir.Bu yapıyı dinamik sorglar üretmek için kullanırız.
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

    }

    //[AttributeUsage(AttributeTargets.Class |AttributeTargets.Field )]

    //AllowMultiple =true Attribute u birden fazla kullanabilir miyim

    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]//
    //[AttributeUsage(AttributeTargets.All)]//Bu atribute ı herkese kullanabilirsin.
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]//Sadece class ların üzerine eklenebilir.
    class ToTableAttribute : Attribute
    {
        string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


}
