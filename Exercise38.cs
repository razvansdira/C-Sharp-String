using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise38
    {
        static void Main(string[] args)
        {
            string a = "kill two birds with one stone";
            string b = "birds";
            bool n = a.Contains(b);
            Console.WriteLine(" '{0}' is the string '{1}' : {2}", b, a, n);
            if (n)
            {
                int index = a.IndexOf(b);
                if (index >= 0)
                    Console.Write(" '{0}' begins at character position {1}", b, index + 1);
            }
            Console.ReadLine();
        }
    }
}
