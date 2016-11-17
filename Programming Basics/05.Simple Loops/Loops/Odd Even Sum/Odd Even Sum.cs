using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                
                if (i % 2 == 0)
                {
                    var evenPosition = int.Parse(Console.ReadLine());
                    evenSum += evenPosition;
                }
                else
                {
                    var oddPosition = int.Parse(Console.ReadLine());
                    oddSum += oddPosition;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes Sum {evenSum}");
            }
            else
            {
                Console.WriteLine($"No Diff {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
