using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace C_Sharp_String
{
    class Exercise24
    {
        static void Main(string[] args)
        {
            string a = "Razvan Sdira";
            string b = "Amalia Crian";

            int n = a.IndexOf(" ");
            n = n < 0 ? 0 : n--;

            int m = b.IndexOf(" ");
            n = n < 0 ? 0 : n--;

            int l = Math.Max(a.Length, b.Length);

            Console.Write("Sorted alphabetically by last name: ");
            if (String.Compare(a, n, b, m, l, new CultureInfo("US"), CompareOptions.IgnoreCase) < 0)
                Console.Write("{0}, {1}.", a, b);
            else
                Console.Write("{0}, {1}.", b, a);
            Console.ReadLine();
        }
    }
}
