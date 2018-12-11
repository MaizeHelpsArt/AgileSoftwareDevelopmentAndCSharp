using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2P2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables that will hold values
            const int numberOfCandiesInBag = 50;
            const int servingsPerBag = 25;
            const int caloriesPerServing = 100;

            // find out how many candies per serving
            double candiesPerServing = numberOfCandiesInBag / servingsPerBag;

            // find out how many calories per candy
            double caloriesPerCandy = caloriesPerServing / candiesPerServing;

            // ask user for number of candies he or she ate
            Console.WriteLine("How many candies did you eat?");

            // get the number from the user
            int candiesAte = int.Parse(Console.ReadLine());

            // calculate how many calories consumed
            double caloriesConsumed = candiesAte * caloriesPerCandy;

            // display data
            Console.WriteLine($"You have consumed {caloriesConsumed} calories.");

            // pause screen
            Console.ReadKey();
        }
    }
}
