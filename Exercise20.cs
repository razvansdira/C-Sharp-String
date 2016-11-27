using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise20
    {
        static void Main(string[] args)
        {
            string a, b, c;
            int n;

            Console.Write(" Input a string: ");
            a = Console.ReadLine();

            Console.Write("Input the strinng to be searched for: ");
            b = Console.ReadLine();

            Console.Write(" Input the string to be inserted: ");
            c = Console.ReadLine();

            n = a.IndexOf(b);
            c = "" + c.Trim() + " ";
            a = a.Insert(n, c);

            Console.Write("The final string is: {0}.", a);
            Console.ReadLine();
         }
    }
}
