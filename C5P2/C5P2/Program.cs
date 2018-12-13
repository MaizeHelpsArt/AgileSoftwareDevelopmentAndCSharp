using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5P2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two employees
            Employee employee1 = new Employee("111", "Alice", DateTime.Parse("12/01/2018"));
            Employee employee2 = new Employee("222", "Bob", DateTime.Parse("01/24/2018"));

            // display
            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.ReadKey();
        }
    }
}
