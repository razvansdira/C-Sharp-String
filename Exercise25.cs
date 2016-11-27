using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading; 

namespace C_Sharp_String
{
    class Exercise25
    {
        static void Main(string[] args)
        {
            String[] culture = { "AU", "SE" };
            String[] a = { "case",  "encyclopedia", "encyclopedia", "Archeology" };
            String[] b = { "case", "encyclopedia", "encyclopedia" , "ARCHEOLOGY" };

            StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            foreach (var Name in culture)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Name);

                Console.WriteLine("Current culture: {0}s", CultureInfo.CurrentCulture.Name);

                for (int i = 0; i <= a.GetUpperBound(0); i++)
                {
                    foreach (var comp in comparisons)
                        Console.WriteLine("   {0} = {1} ({2}): {3}", a[i], b[i], comp, String.Equals(a[i], b[i], comp));
                }
            }
            Console.ReadLine();
        }
    }
}
