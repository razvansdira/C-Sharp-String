using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise8
    {
        public static void Main(string[] args)
        {
            string a;
            int i=0, j;


            Console.Write(" Input a string: ");
            a = Console.ReadLine();
            j = a.Length;
            string[] b = new string[j];

            while (i < j)
            {
                string x = a[i].ToString();
                b[i] = x;
                i++;
            }
            Console.Write("The copied string is: {0}", string.Join("", b));
            Console.ReadLine();
        }
    }
}
