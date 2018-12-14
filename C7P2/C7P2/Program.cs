using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7P2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables to hold user values
            double wholeSalePrice;
            double markupPercentage;

            // promt user for both
            Console.WriteLine("Enter Wholesale Price:");
            while (!(double.TryParse(Console.ReadLine(), out wholeSalePrice)) || (wholeSalePrice < 0 ))
            {
                Console.WriteLine("Wholsesale price must be numeric and positive.");
            }

            // wholesale price is valid
            Console.WriteLine("Enter markup percentage");
            while (!(double.TryParse(Console.ReadLine(), out markupPercentage)) || markupPercentage < 0)
            {
                Console.WriteLine("Markup must be numeric and positive");
            }
            // markup is valid
            // calculate retail price
            double retailPrice = wholeSalePrice * (1 + markupPercentage / 100);
            // display
            Console.WriteLine($"Retail Price {retailPrice}");
            Console.ReadKey();
        }
    }
}
