using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise39
    {
        static void Main()
        {
            string a = "C Sharp";
            string b = "Python";

            Console.WriteLine("a = '{0}'", a);
            Console.WriteLine("b = '{0}'", b);

            Console.WriteLine("\n After string copy");
            b = String.Copy(a);
            Console.WriteLine("a = '{0}'", a);
            Console.WriteLine("b = '{0}'", b);

            Console.WriteLine(" Reference equals: {0}", Object.ReferenceEquals(a, b));
            Console.WriteLine("Equals: {0}", Object.Equals(a, b));

            Console.WriteLine("\n After assignment");
            b = a;
            Console.WriteLine("a = '{0}'", a);
            Console.WriteLine("b = '{0}'", b);

            Console.WriteLine(" Reference equals: {0}", Object.ReferenceEquals(a, b));
            Console.WriteLine("Equals: {0}", Object.Equals(a, b));
            Console.ReadLine();
        }
    }
}
