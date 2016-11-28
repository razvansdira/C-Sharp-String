using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace C_Sharp_String
{
    class Exercise28
    {
        static void Main(string[] args)
        {
            string a = "sister";
            string b = "Sister";
            string n;
            int r;

            r = String.Compare(a, b, new CultureInfo("en-US"), CompareOptions.None);

            if (r > 0)
                n = "comes after";
            else if (r == 0)
                n = "is the same as";
            else
                n = "comes before";

            Console.WriteLine(" '{0}' {1} '{2}'", a, n, b);

            r = String.Compare(a, b, new CultureInfo("en-US"), CompareOptions.IgnoreCase);

            if (r > 0)
                n = "comes after";
            else if (r == 0)
                n = "is the same as";
            else
                n = "comes before";

            Console.WriteLine(" '{0}' {1} '{2}'",
                              a, n, b);

            // Culture-insensitive ordinal comparison.  
            r = String.CompareOrdinal(a, b);
            if (r > 0)
                n = "comes after";
            else if (r == 0)
                n = "is the same as";
            else
                n = "comes before";

            Console.WriteLine(" '{0}' {1} '{2}'", a, n, b);
            Console.ReadLine();
        }
    }
}
