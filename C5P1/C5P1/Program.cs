using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two students
            Student student1 = new Student("Alice", 97);
            Student student2 = new Student("Bob", 87);

            // display data
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.ReadKey();
        }
    }
}
