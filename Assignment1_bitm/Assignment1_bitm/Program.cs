using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_bitm
{
    class info
    {
        public void infodata()
        {
            string[] data = new string[100];

            Console.WriteLine("Enter your name");
            data[0] = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            data[1] = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            data[2] = Console.ReadLine();
            Console.WriteLine("Enter your Contact");
            data[3] = Console.ReadLine();
            // Console.WriteLine(data[0] + data[1] +data[2] +data[3]);
            Console.WriteLine();
            Console.WriteLine("Name: " + data[0]);
            Console.WriteLine("Age: " + data[1]);
            Console.WriteLine("Address: " + data[2]);
            Console.WriteLine("Contact: " + data[3]);
            Console.WriteLine();



           // Console.ReadKey();
        }
    
    }


    class Program
    {
        
       
        static void Main(string[] args)
        {
          /*  string name;
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
            Console.WriteLine("Contact: " +contact);*/
            
                info f = new info();
                for (int i = 1; i <= 100; i++)
                {
                    f.infodata();
                }

        }
    }
}
