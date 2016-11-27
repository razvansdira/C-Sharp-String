using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            int x, y, z;
            string a;
            char l;
            char[] arr;

            Console.Write(" Input a string: ");
            a = Console.ReadLine();
            z = a.Length;
            arr = a.ToCharArray(0, z);

            for(x=1;x<z; x++)
                for(y=0; y<z-x; y++)
                    if (arr[y] > arr[y + 1])
                    {
                        l = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = l;
                    }
            Console.Write("After sorting: ");
            foreach(char c in arr)
            {
                l = c;
                Console.Write("{0} ", l);
            }
            Console.ReadLine();
        }
    }
}
