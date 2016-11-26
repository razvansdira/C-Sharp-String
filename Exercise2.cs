using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            string x;
            int y=0;
            Console.Write(" Input a string: ");
            x = Console.ReadLine();

            foreach (char a in x)
                y += 1;

            Console.Write("Length of the stirng is: {0}", y);
            Console.ReadLine();
        }
    }
}
