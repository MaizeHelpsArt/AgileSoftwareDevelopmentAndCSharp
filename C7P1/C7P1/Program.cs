using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// prompt user for wholse sale price and markup percentage
            //Console.WriteLine("Enter Wholesale Price:");
            //double wholeSalePrice = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Markup Percentage:");
            //double markupPercentage = double.Parse(Console.ReadLine());

            //// calculate retail price
            //double retailPrice = wholeSalePrice * (1 + markupPercentage / 100);

            //// display
            //Console.WriteLine($"Retail Price: {retailPrice:C}");
            //Console.ReadKey();

            double wholeSalePrice;
            double markupPercentage;

            Console.WriteLine("Enter Wholesale Price:");
            if (!(double.TryParse(Console.ReadLine(), out wholeSalePrice)))
            {
                Console.WriteLine("Markup must be numeric");
            }
            else
            {
                Console.WriteLine("Enter Markup Percentage:");
                if (!(double.TryParse(Console.ReadLine(), out markupPercentage)))
                {
                    Console.WriteLine("Markup must be numberic");
                }
                else
                {
                    double retailPrice = wholeSalePrice * (1 + (markupPercentage / 100));

                    Console.WriteLine($"Retail Price: {retailPrice:C}");
                }
            }
            Console.ReadKey();
        }
    }
}
