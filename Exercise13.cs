using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            string x;
            char[] arr;
            int a, b, c, d = 0;

            Console.Write("  Input a string: ");
            x = Console.ReadLine();
            c = x.Length;
            arr = x.ToCharArray(0, c);

            Console.Write("Input the position to start extraction: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("  Input the length of substring: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("The substring retrieve from the string is: ");

            while (d < b)
            {
                Console.Write(arr[a + d - 1]);
                d++;
            }
            Console.ReadLine();
        }
    }
}
