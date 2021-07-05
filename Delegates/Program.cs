using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();  
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAllert();
            
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAllert()
        {
            Console.WriteLine("Be carefull");
        }
    }
}
