using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise18
    {
        static void Main(string[] args)
        {
            Console.Write(" Input a caracter: ");
            char c = (char)Console.Read();

            if (Char.IsLetter(c))
            {
                if (Char.IsUpper(c))
                    Console.Write("The character is uppercase.");
                else
                    Console.Write("The character is lowercase.");
            }
            else
                Console.Write("The character is non-alphabetic.");

            Console.ReadLine();
        }
    }
}
