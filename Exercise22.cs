using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise22
    {
        static void Main(string[] args)
        {
            String a = "COMPUTER";
            String b = "computer";
            String c;
            int n;

            Console.WriteLine("  First = '{0}'\n Second = '{1}'", a, b);
            Console.WriteLine("  Ignore case: ");
            n = String.Compare(a, 2, b, 2, 2, true);

            c = ((n < 0) ? "less than" : ((n > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", a.Substring(2, 5), a);

            Console.Write("{0} ", c);
            Console.WriteLine("substring '{0}' in '{1}'", b.Substring(2, 4), b);

            Console.WriteLine("  Honor case: ");
            n = String.Compare(a, 2, b, 2, 2, false);

            c = ((n < 0) ? "less than" : ((n > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", a.Substring(2, 2), a);

            Console.Write("{0} ", c);
            Console.WriteLine("substring '{0}' in '{1}'", b.Substring(2, 2), b);

            Console.ReadLine();
        }
    }
}
