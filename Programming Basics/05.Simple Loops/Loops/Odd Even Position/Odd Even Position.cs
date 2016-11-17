using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var oddSum = 0.00;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            var evenSum = 0.00;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (evenMin > num )
                    {
                        evenMin = num;
                    }
                    if (evenMax < num)
                    {
                        evenMax = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (oddMin > num)
                    {
                        oddMin = num;
                    }                    
                    if (oddMax < num)
                    {
                        oddMax = num;
                    }                    
                }
            }
            

            Console.WriteLine($"OddSum={oddSum}");
          if (oddMin != double.MaxValue)
          {
            Console.WriteLine($"OddMin={oddMin}");
          }
          else
          {
              Console.WriteLine("OddMin=No");
          }
          if (oddMax != double.MinValue)
          {
            Console.WriteLine($"OddMax={oddMax}");
          }
          else
          {
         Console.WriteLine("OddMax=No");
          }
      
      
          Console.WriteLine($"EvenSum={evenSum}");
          if (evenMin != double.MaxValue)
          {
              Console.WriteLine($"EvenMin={evenMin}");
          }
          else
          {                
              Console.WriteLine("EvenMin=No");
          }
          if (evenMax != double.MinValue)
          {
              Console.WriteLine($"EvenMax={evenMax}");
          }
          else 
          {
              Console.WriteLine("EvenMax=No");
          }

        }
    }
}
