using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise14
    {
        static void Main(string[] args)
        {
            string a, b;
            bool x;

            Console.Write(" Input a string: ");
            a = Console.ReadLine();

            Console.Write("Input the substring to be search: ");
            b = Console.ReadLine();

            x = a.Contains(b);
            if (x)
                Console.Write(" The substring exists in the string.");
            else
                Console.Write(" The substring is not exists in the string.");
            Console.ReadLine(); ;
        }
    }
}
