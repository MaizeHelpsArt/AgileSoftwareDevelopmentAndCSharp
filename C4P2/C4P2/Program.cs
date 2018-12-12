using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4P2
{
    class Program
    {
        static void Main(string[] args)
        {
            // two int varriables with values
            int a = 3;
            int b = 5;

            // call the Plus() method and store the return value in total
            int total = Plus(a, b);

            // display result
            Console.WriteLine($"The sum of {a} and {b} is {total}");
            Console.ReadKey();
        }

        // Plus method
        static int Plus(int x, int y)
        {
            int sum;
            sum = x + y;
            return sum;
        }
    }
}
