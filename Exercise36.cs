using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise36
    {
        static void Main(string[] args)
        {
            string a = "Ana ";
            string b = "are ";
            string c = "mere.";

            var d = string.Concat(a, b, c);
            Console.Write(d);
            Console.ReadLine();
        }
    }
}
