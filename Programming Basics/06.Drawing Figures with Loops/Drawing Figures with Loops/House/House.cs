using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var starsCout = 1;
            if (n % 2 == 0)
            {
                starsCout++;
            }


            for (int row = 0; row < (n + 1) / 2; row++)
            {
                var dashCount = ((n - starsCout) / 2);

                Console.WriteLine(new string('-', dashCount)
                                + new string('*', starsCout)
                                + new string('-', dashCount));
                starsCout += 2;
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }
        }
    }
}