using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Exercise35
    {
        static void Main(string[] args)
        {
            const int size = 4;
            string[] words = { "abcd", "efgh", "rstv", "wxyz" };

            double[] keys = new double[size];
            string[] letters = new string[size];

            Random rnd = new Random();

            foreach (string word in words)
            {
                for (int ctr = 0; ctr < word.Length; ctr++)
                {
                    keys[ctr] = rnd.NextDouble();
                    letters[ctr] = word[ctr].ToString();
                }
                Array.Sort(keys, letters, 0, size, Comparer.Default);
                string scrambledWord = String.Concat(letters[0], letters[1], letters[2], letters[3]);

                Console.WriteLine("  {0} => {1}", word, scrambledWord);
                Console.ReadLine();
            }
        }
    }
}
