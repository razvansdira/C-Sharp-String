using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise26
    {
        static void Main (String[] args)
        {
            String up = "ASDF";
            String low = "qwer";

            Console.Write("   Comparing '{0}' and '{1}':",up,low);
            Console.Write("\n The strings are equal when capitalized {0}", String.Compare(up.ToUpper(), low.ToUpper()) == 0 ? "true" : "false");

            Console.Write("\n The strings are equal when case is ignored? {0}", String.Compare(up, low, true) == 0 ? "true" : "false");
            Console.ReadLine();
        }
    }
}
