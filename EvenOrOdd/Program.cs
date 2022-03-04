using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd.EvenOrOdd1(5));
            Console.WriteLine(EvenOrOdd.EvenOrOdd2(5));
            Console.WriteLine(EvenOrOdd.EvenOrOdd3(5));
            Console.WriteLine(EvenOrOdd.EvenOrOdd1(26));
            Console.WriteLine(EvenOrOdd.EvenOrOdd2(26));
            Console.WriteLine(EvenOrOdd.EvenOrOdd3(26));

        }
    }
}
