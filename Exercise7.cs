using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise7
    {
        public static void Main(string[] args)
        {
            string a;
            int i, j, k, l, m;
            i = j = k = m = 0;
            

            Console.Write(" Input a string: ");
            a = Console.ReadLine();
            l = a.Length;

            while (i < l)
            {
                if ((a[i] >= 'a' && a[i] <= 'z') || (a[i] >= 'A' && a[i] <= 'Z'))
                    j++;
                else if (a[i] >= '0' && a[i] <= '9')
                    k++;
                else
                    m++;
                i++;
            }
            Console.Write("Number of alphabets in the string is: {0}", j);
            Console.Write("\n Number of digits in the string is: {0}", k);
            Console.Write("\nNumber of special characters in the string is: {0}\n\n", m);
            Console.ReadLine();
        }
    }
}
