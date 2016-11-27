using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise17
    {
        static void Main(string[] args)
        {
            string x, y;
            Console.Write(" Input a string: ");
            x = Console.ReadLine();

            Console.Write("Input a string to be found in the string: ");
            y = Console.ReadLine();

            int n = x.IndexOf(y);
            if (n < 0)
                Console.Write("Not found.");
            else
                Console.Write("Found '{0}' in '{1}' at position {2}. ", y, x, n);
            Console.ReadLine();
        }
    }
}
