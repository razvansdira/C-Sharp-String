using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            string[] arr;
            string x;
            int a, b, c, d;

            Console.Write("  Input number of string: ");
            a = Convert.ToInt32(Console.ReadLine());
            arr = new string[a];
            Console.WriteLine(" Input {0} strings below: ", a);

            for (b = 0; b < a; b++)
                arr[b] = Console.ReadLine();
            d = arr.Length;

            for(b=0; b<d; b++)
            {
                for(c=0; c<d-1; c++)
                {
                    if (arr[c].CompareTo(arr[c + 1]) > 0)
                    {
                        x = arr[c];
                        arr[c] = arr[c + 1];
                        arr[c + 1] = x;
                    }
                }
            }
            Console.Write(" After sorting: ");
            for (b = 0; b < d; b++)
                Console.Write(arr[b] + " ");
            Console.ReadLine();
        }
    }
}
