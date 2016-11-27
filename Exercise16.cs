using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise16
    {
        static void Main(string[] args)
        {
            string user, pass;
            int a = 0;

            do
            {
                Console.Write("Input a username: ");
                user = Console.ReadLine();

                Console.Write(" Input a password: ");
                pass = Console.ReadLine();

                if (user != "razvan" || pass != "asd123!@#")
                    a++;
                else
                    a = 1;
            }
            while ((user != "razvan" || pass != "asd123!@#") && (a != 3));

            if (a == 3)
                Console.Write("Try later !!!");
            else
                Console.Write("Password entered successfull !!!");
            Console.ReadLine();
        }
    }
}
