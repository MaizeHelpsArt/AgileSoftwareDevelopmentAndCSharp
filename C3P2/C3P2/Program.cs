using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3P2
{
    class Program
    {
        static void Main(string[] args)
        {
            // promt user for a score
            Console.WriteLine("Enter student score(-1 to terminate):");

            // store the score in a variable
            double score = double.Parse(Console.ReadLine());

            // start loop
            while(score >= 0)
            {
                // see if the grade is higher than 90
                if (score >=90)
                {
                    Console.WriteLine("Congratulations");
                }
                else
                {
                    Console.WriteLine("Thanks for using the system");
                }
                // promt the user for a score
                Console.WriteLine("Enter student score(-1 to terminate):");
                score = double.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
