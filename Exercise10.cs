using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            string x;
            int[] a = new int[200];
            int i = 0, j, l, m=0;

            Console.Write(" Input a string: ");
            x = Console.ReadLine();
            l = x.Length;

            for (i = 0; i < 200; i++)
                a[i] = 0;
            i = 0;
            while (i < l)
            {
                j = (int)x[i];
                a[j] += 1;
                i++;
            }
            for (i = 0; i < 200; i++)
            {
                if (i != 32)
                {
                    if (a[i] > a[m])
                        m = i;
                }
            }
            Console.Write("The highest frequency of character '{0}' it appears for number of times: {1}.", (char)m, a[m]);
            Console.ReadLine();
        }
    }
}
