using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise31
    {
        static void Main(string[] args)
        {
            string a = "facultate";
            string b = "scoala";
            string c;
            int r;

            Console.Write("   a = '{0}', b = '{1}'", a, b);
            r = string.CompareOrdinal(a, b);
            c = ((r < 0) ? "less than" : ((r > 0) ? "greater than" : "equal to"));

            Console.Write("\n String '{0}' is ", a);
            Console.Write("{0} ", c);

            Console.Write("string '{0}'.", b);
            Console.ReadLine();

        }
    }
}
