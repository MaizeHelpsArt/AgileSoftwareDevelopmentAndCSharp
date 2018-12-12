using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4P1
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayText("I am number one");
            DisplayText("I am number two");
            Console.ReadKey();
        }
        // DisplayText method
        static void DisplayText(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("************");
        }
    }
}
