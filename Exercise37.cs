using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise37
    {
        static void Main(string[] args)
        {
            string[] a = { "hei ", "welcome ", "to ", "create ", "C# ", "client ", "app " };
            Console.WriteLine(string.Concat(a));

            Array.Sort(a);
            Console.Write(string.Concat(a));
            Console.ReadLine();
        }
    }
}
