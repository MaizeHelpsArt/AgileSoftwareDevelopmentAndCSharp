using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7P3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // prompt user for dividen
                Console.WriteLine("Enter Dividend:");
                int dividend = int.Parse(Console.ReadLine());

                // prompt user for divisor
                Console.WriteLine("Enter Divisor:");
                int divisor = int.Parse(Console.ReadLine());

                // calculate the quotient
                int quotient = dividend / divisor;

                // display
                Console.WriteLine($"{dividend} divided by {divisor} equals {quotient}");
                Console.ReadKey();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();

            }
        }
    }
}
