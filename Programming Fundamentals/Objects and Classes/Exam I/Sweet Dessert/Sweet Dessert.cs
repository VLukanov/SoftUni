using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var gests = int.Parse(Console.ReadLine());
            var priceBanabas = decimal.Parse(Console.ReadLine());
            var priceEggs = decimal.Parse(Console.ReadLine());
            var priceBerries = decimal.Parse(Console.ReadLine());

            var sets = gests / 6;
            if (gests % 6 != 0)
            {
                sets++;
            }

            var pricePerSet = 2 * priceBanabas + 4 * priceEggs + (decimal) 0.2 * priceBerries;
            var priceAll = sets * pricePerSet;
            if (cash < priceAll)
            {
                var neededMoney = priceAll - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {priceAll:f2}lv.");
            }
        }
    }
}
