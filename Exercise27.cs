using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace C_Sharp_String
{
    class Exercise27
    {
        static void Main(string[] args)
        {
            String a = "change";
            String b = "euro";
            String n = null;

            n = symbol(String.Compare(a, b, false, new CultureInfo("en-US")));
            Console.WriteLine("  For US: {0} {1} {2}", a, n, b);

            n = symbol(String.Compare(a, b, false, new CultureInfo("cs-CZ")));
            Console.WriteLine("  For CZ: {0} {1} {2}\n", a, n, b);

            Console.ReadLine();
        }

        private static String symbol(int x)
        {
            String s = "=";
            if (x < 0) s = "<";
            else if (x > 0) s = ">";
            return s;
        }  
    }
}
