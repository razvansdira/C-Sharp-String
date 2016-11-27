using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            string x;
            int i, l, c=0, v=0;

            Console.Write(" Input a string: ");
            x = Console.ReadLine();

            l = x.Length;
            for(i=0; i < l; i++)
            {
                if (x[i] == 'a' || x[i] == 'e' || x[i] == 'i' || x[i] == 'o' || x[i] == 'u')
                    v++;
                else if (x[i] >= 'a' && x[i] <= 'z')
                    c++;
            }
            Console.Write("  The total of vowel is: {0}",v);
            Console.Write("\nThe total of consonant is: {0}",c);
            Console.ReadLine();
        }
    }
}
