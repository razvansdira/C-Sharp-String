using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace C_Sharp_String
{
    class Exercise23
    {
        static void Main(string[] args)
        {
            String a = "COMPUTER";
            String b = "computer";
            String c;
            int n;

            Console.WriteLine("  First = '{0}'\n Second = '{1}'", a, b);
            Console.WriteLine("  Ignore case, Turkish culture: ");
            n = String.Compare(a, 4, b, 4, 2, true, new CultureInfo("TR"));

            c = ((n < 0) ? "less than" : ((n > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", a.Substring(4, 3), a);

            Console.Write("{0} ", c);
            Console.WriteLine("substring '{0}' in '{1}'", b.Substring(4, 3), b);

            Console.WriteLine("  Ignore case, invariant culture: ");
            n = String.Compare(a, 4, b, 4, 2, true, CultureInfo.InvariantCulture);

            c = ((n < 0) ? "less than" : ((n > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", a.Substring(4, 2), a);

            Console.Write("{0} ", c);
            Console.WriteLine("substring '{0}' in '{1}'", b.Substring(4, 2), b);

            Console.ReadLine();
        }
    }
}
