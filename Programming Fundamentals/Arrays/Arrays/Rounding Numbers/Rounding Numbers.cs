using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var num in numbers)
            {
                var roundNum = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine(num + " => " + roundNum);
            }
        }
    }
}
