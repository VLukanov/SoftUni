using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var bonusPoint = 0.00;            

            if (num <= 100)
            {
                bonusPoint += 5;                
              
            }
            else if (num < 1000)
            {
                bonusPoint = num * 0.20;                
            }
            else
            {
                bonusPoint = num * 0.10;                
            }
            if (num % 2 == 0)
            {
                bonusPoint += 1;
            }
            else if (num % 10 == 5)
            {
                bonusPoint += 2;
            }
            Console.WriteLine(bonusPoint);
            Console.WriteLine(bonusPoint + num);
        }
    }
}
