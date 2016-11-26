using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            string x;
            int a=1, b=0;
            Console.Write(" Input a string: ");
            x = Console.ReadLine();

            while (b <= x.Length - 1)
            {
                if (x[b] == ' ' || x[b] == '\n')
                    a++;
                b++;
            }

            Console.Write("The number of the stirng is: {0}", a);
            Console.ReadLine();
        }
    }
}
