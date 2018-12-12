using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4P3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create three int variables
            int a = 11;
            int b = 5;
            int remainder;

            // call the Divide() method and store the return value in quotient
            int quotient = Divide(a, b, out remainder);

            // display results
            Console.WriteLine($"{a} divided by {b} is {quotient} with remainder of {remainder}");
            Console.ReadKey();
        }
        static int Divide(int x, int y, out int r)
        {
            int q;
            q = x / y;
            r = x % y;
            return q;
        }
    }
}
