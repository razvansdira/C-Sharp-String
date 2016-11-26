using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            string x;
            int y=0;
            Console.Write(" Input a string: ");
            x = Console.ReadLine();

            while (y <= x.Length - 1)
            {
                Console.Write("{0} ", x[y]);
                y++;
            }

            Console.Write(" is the separate stirng.");
            Console.ReadLine();
        }
    }
}
