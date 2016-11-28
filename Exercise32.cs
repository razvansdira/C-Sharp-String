using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise32
    {
        static void Main(string [] args)
        {
            var tst = new test();
            object[] Compare = { tst, tst.ToString(), 112, 112.ToString(), "some txt", "Some txt" };
            string a = "some txt";
            foreach(var comparabil in Compare)
            {
                try
                {
                    int i = a.CompareTo(comparabil);
                    Console.WriteLine("  Comparing '{0}' with '{1}' : {2}", a, comparabil, i);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Bad argument: {0} (type {1})", comparabil, Compare.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }

    internal class test
    {
        public test()
        {
        }
    }
}
