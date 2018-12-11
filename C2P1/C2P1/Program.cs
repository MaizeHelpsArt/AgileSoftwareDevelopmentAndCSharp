using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // promot user for a name
            Console.WriteLine("Enter your name: ");

            // store the value in a variable
            string name = Console.ReadLine();

            // display the message
            Console.WriteLine($"Welcome to Agile, {name}");

            Console.ReadKey();
        }
    }
}
