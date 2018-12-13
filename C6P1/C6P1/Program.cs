using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6P1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();

            Undergraduate ud1 = new Undergraduate("111", "Alice", 98);
            allStudents.Add(ud1);

            Undergraduate ud2 = new Undergraduate("222", "Bob", 88);
            allStudents.Add(ud2);

            Undergraduate g1 = new Undergraduate("333", "Chuck", 76);
            allStudents.Add(g1);

            Undergraduate g2 = new Undergraduate("444", "Dan", 56);
            allStudents.Add(g2);

            foreach(Student s in allStudents)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
