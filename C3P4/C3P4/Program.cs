using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3P4
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an in array that can hold 10 student scores
            int[] scores = new int[10];

            // using a loop to prompt user for score, one at a time 
            for (int count = 0; count < scores.Length; count++)
            {
                Console.WriteLine("Enter a score:");
                scores[count] = int.Parse(Console.ReadLine());
            }

            // create variables to hold number of grade letters
            int numberOfA = 0;
            int numberOfB = 0;
            int numberOfC = 0;
            int numberOfD = 0;
            int numberOfF = 0;

            // using a loop to check each score to find out which letter grade it is
            for (int count = 0; count < scores.Length; count++)
            {
                if (scores[count] >= 90)
                {
                    numberOfA++;
                }
                else if (scores[count] >= 80)
                {
                    numberOfB++;
                }
                else if (scores[count] >= 70)
                {
                    numberOfC++;
                }
                else if (scores[count] >= 60)
                {
                    numberOfD++;
                }
                else
                {
                    numberOfF++;
                }

            }
            // display the result
            Console.WriteLine($"Number of As: {numberOfA}");
            Console.WriteLine($"Number of Bs: {numberOfB}");
            Console.WriteLine($"Number of Cs: {numberOfC}");
            Console.WriteLine($"Number of Ds: {numberOfD}");
            Console.WriteLine($"Number of Fs: {numberOfF}");
            Console.ReadKey();
        }
    }
}
