using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise6
    {
        public static void Main (string[] args)
        {
            string a, b;
            int i = 0, j = 0, k = 0, x, y;

            Console.Write("  Input the fisrt string: ");
            a = Console.ReadLine();

            Console.Write(" Input the second string: ");
            b = Console.ReadLine();

            x = a.Length;
            y = b.Length;
            if (x == y)
            {
                for(i=0; i<x; i++)
                {
                    if (a[i] != b[i])
                    {
                        k = 1;
                        i = x;
                    }
                }
            }
            if (x == y)
                j = 0;
            else if (x > y)
                j = 1;
            else if (x < y)
                j = -1;

            if (j == 0)
            {
                if (k == 0)
                    Console.Write("Thee length of both strings are equal, both are same.");
                else
                    Console.Write("The length of both strings are equal, but they are not same.");
            }
            else if (j == -1)
                Console.Write("The lenth of the string is smaller than second.");
            else
                Console.Write("The length of the string is greater than second.");
            Console.ReadLine();
        }
    }
}
