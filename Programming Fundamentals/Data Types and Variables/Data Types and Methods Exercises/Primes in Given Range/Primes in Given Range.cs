using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            var result = GetPrimesInRange(start, end);
        }

        static List<int> GetPrimesInRange(int starRange, int endRange)
        {
            List<int> primes = new List<int>();
            primes.Add(2);

            for (int i = 3; i < endRange; i++)
            {
                for (int j = 0; j < primes.Count; i++)
                {
                    if (i % primes[j] == 0)
                    {
                        continue;
                    }
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
