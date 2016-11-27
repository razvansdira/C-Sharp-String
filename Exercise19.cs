using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise19
    {
        static void Main (string[] args)
        {
            string x, y;
            int a = 0, b = -1, c = -1;

            Console.Write("  Input a string: ");
            x = Console.ReadLine();
            Console.Write("Input the string to be searched for: ");
            y = Console.ReadLine();

            while (a != -1)
            {
                a = x.IndexOf(y, c + 1);
                b += 1;
                c = a;
            }
            Console.Write(" The string '{0}' occurs " + b + " times.", y);
            Console.ReadLine();
        }
    }
}
