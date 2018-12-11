using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3P3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare an array that can hold 10 int scores
            int[] scores = new int[10];

            // using a loop to prompt user for input, one score at a time
            for (int count = 0; count < scores.Length; count++)
            {
                Console.WriteLine("Enter a score:");
                scores[count] = int.Parse(Console.ReadLine());
            }
            // Display statistics
            Console.WriteLine($"Average: {scores.Average()}");
            Console.WriteLine($"Highest: {scores.Max()}");
            Console.WriteLine($"Lowest: {scores.Min()}");
            Console.ReadKey();
        }
    }
}
