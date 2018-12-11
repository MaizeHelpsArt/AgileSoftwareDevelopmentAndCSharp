using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2P3
{
    class Program
    {
        static void Main(string[] args)
        {
            // promt user for amount of change and store in a variable
            Console.WriteLine("Enter change amount:");
            decimal changeAmount = decimal.Parse(Console.ReadLine());

            // make the amount into a whole number
            int changeAmountInPennies
                = (int)(changeAmount * 100);

            // calculate the number of quarters needed
            int numberOfQuarters = changeAmountInPennies / 25;

            // calculate the remainder
            int remainderAfterQuarter = changeAmountInPennies % 25;

            // calculate the number of dimes needed
            int numberOfDimes = remainderAfterQuarter / 10;

            // calculate the remainder
            int remainderAfterDime = changeAmountInPennies % 10;

            // calculate the number of nickles needed
            int numberOfNickles = remainderAfterDime / 5;

            // calculate the remainder which is also the number of pennies
            int remainderAfterNickle = remainderAfterDime % 5;
            int numberOfPennies = remainderAfterNickle;

            // display results
            Console.WriteLine($"Number of Quarters: {numberOfQuarters}");
            Console.WriteLine($"Number of Dimes: {numberOfDimes}");
            Console.WriteLine($"Number of Nickles: {numberOfNickles}");
            Console.WriteLine($"Number of Pennies: {numberOfPennies}");
            Console.ReadKey();
        }
    }
}
