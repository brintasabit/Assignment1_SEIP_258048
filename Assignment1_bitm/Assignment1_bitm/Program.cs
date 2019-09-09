using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_bitm
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string address;
            string contact;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
          //  Console.WriteLine("Your name\n" +name);
            Console.WriteLine("Enter your age");
            age = Console.ReadLine();
           // Console.Write("Your entered age is\n" +age);
            Console.WriteLine("Enter your address");
            address=Console.ReadLine();
          //  Console.WriteLine("Your address is\n" +address);
            Console.WriteLine("Enter your contact");
            contact = Console.ReadLine();
           // Console.WriteLine("Your contact is\n" +contact);
            Console.WriteLine();
           // Console.WriteLine( name  + age  + address  + contact);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: " +age);
            Console.WriteLine("Address: " +address);
            Console.WriteLine("Contact: " +contact);
            Console.ReadKey();

        }
    }
}
