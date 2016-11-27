using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise15
    {
        static void Main(string[] args)
        {
            string x;
            char[] arr;
            char c;
            int i, l = 0;

            Console.Write(" Input a string: ");
            x = Console.ReadLine();
            l = x.Length;
            arr = x.ToCharArray(0, l);

            Console.Write("After conversion: ");
            for (i = 0; i < l; i++)
            {
                c = arr[i];
                if (Char.IsLower(c))
                    Console.Write(Char.ToUpper(c));
                else
                    Console.Write(Char.ToLower(c));
            }
            Console.ReadLine();
        }
    }
}
