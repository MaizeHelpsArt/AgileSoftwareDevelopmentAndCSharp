using System;

namespace C1P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a blue background for the text
            Console.BackgroundColor = ConsoleColor.Blue;

            // make the text red
            Console.ForegroundColor = ConsoleColor.Red;

            // create a title
            Console.Title = "Welcome";

            // display the text
            Console.WriteLine("Welcome to Agile");

            // program pause waiting for user to hit a key
            Console.ReadKey();
        }
    }
}
