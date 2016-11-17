using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a1 = 0; a1 < n; a1++)
            {
                for (int b1 = 0; b1 < n; b1++)
                {
                    for (int c1 = 0; c1 < n; c1++)
                    {
                        char letter1 = (char)('a' + a1);
                        char letter2 = (char)('a' + b1);
                        char letter3 = (char)('a' + c1);
                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
                    }
                }
            }
        }
    }
}
