using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var partOfDay = Console.ReadLine();

            if (num < 20)
            {
                var startPrice = 0.70;
                if (partOfDay == "day")
                {
                    Console.WriteLine(startPrice + num * 0.79);
                }
                else if (partOfDay == "night")
                {
                    Console.WriteLine(startPrice + num * 0.90);
                }
            }
            else if (num >=20 && num < 100)
            {
                Console.WriteLine(num * 0.09);
            }
            else
            {
                Console.WriteLine(num * 0.06);
            }
        }
    }
}
