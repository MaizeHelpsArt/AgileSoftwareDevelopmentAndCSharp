using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6P2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create customers and display
            VIPCustomer c1 = new VIPCustomer("111", "Alice");
            c1.MakePurchase(500);
            Console.WriteLine(c1);
            c1.MakePurchase(1000);
            Console.WriteLine(c1);
            c1.MakePurchase(100);
            Console.WriteLine(c1);
            Console.WriteLine();

            MemberCustomer c2 = new MemberCustomer("222", "Bob");
            c2.MakePurchase(500);
            Console.WriteLine(c2);
            c2.MakePurchase(1000);
            Console.WriteLine(c2);
            Console.ReadKey();
        }
    }
}
