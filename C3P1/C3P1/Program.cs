using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // promt the user for a score
            Console.WriteLine("Enter student score:");

            // store the score in a variable
            double score = double.Parse(Console.ReadLine());

            // check and see if the score is 90 or higher
            if (score >= 90)
            {
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("Thank you for using the system");
            }
            Console.ReadKey();
        }
    }
}
