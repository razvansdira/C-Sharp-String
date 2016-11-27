using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise21
    {
        static void Main(string[] args)
        {
            String a = "exercise";
            String b = "homework";
            String c;
            int n;

            Console.WriteLine("Primul string = '{0}'\n    Al doilea = '{1}'", a, b);
            n = String.Compare(a, 2, b, 0, 2);
            
            c = ((n < 0) ? "less than" : ((n > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", a.Substring(4, 2), a);

            Console.Write("{0} ", c);
            Console.WriteLine("substring '{0}' in '{1}'", b.Substring(2, 5), b);

            Console.ReadLine();
        }
    }
}
