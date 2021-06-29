using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class Customer
        {

            // private int Id { get; set; }//Private değişkenler sadece tanımlandığı blokta geçerlidir.
            //protected int Id { get; set; }//Private in tüm özelliklerini taşır. başka inherit edildiği sınıflarda kullanılır. 
            public void Save()
            {
                 
            }
            public void Delete()
            {

            }
        }
        class Student:Customer
        {
            public void Save2()
            {
                //Customer customer = new Customer();
               
            }
        }
        internal class Course
        {
            public string Name { get; set; }
        }
    }
}
