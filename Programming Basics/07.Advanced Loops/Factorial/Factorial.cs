using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var n = 1;
            do
            {
                n = n * num;
                num--;
            } while (n > 1);
            Console.WriteLine(n);


         //  for (int i = num; i >= 1; i--)
         //  {
         //      n = n * i;
         //      
         //  }
         //  Console.WriteLine(n);

        }
    }
}
