using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Info_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "", address = "", contact = "";
            int age;
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your address : ");
            address = Console.ReadLine();
            Console.WriteLine("Enter your contact : ");
            contact = Console.ReadLine();

            Console.WriteLine("Details of your info : " + "\n" + "Name: " + name + "\n" + "Age: " + age + "\n"
                + "Address: " + address + "\n" + "Contact: " + contact);
            Console.ReadKey();
        }
    }
}
