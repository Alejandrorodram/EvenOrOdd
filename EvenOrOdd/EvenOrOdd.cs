using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    internal class EvenOrOdd
    {
        public static string EvenOrOdd1(int number)
        {
            // Code goes here...
            if (number % 2 == 0)
            {
                return ("Even");
            }
            else
            {
                return ("Odd");
            }
        }
        public static string EvenOrOdd2(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
        public static string EvenOrOdd3(int number)
            => number % 2 == 0 ? "Even" : "Odd";

    }
}
