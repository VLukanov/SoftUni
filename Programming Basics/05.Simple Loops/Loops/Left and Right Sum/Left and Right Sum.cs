using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                var leftnum = int.Parse(Console.ReadLine());
                leftSum += leftnum;
            }
            for (int i = 0; i < n; i++)
            {
                var rightnum = int.Parse(Console.ReadLine());
                rightSum += rightnum;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff {Math.Abs(leftSum - rightSum)}");
            }            
        }
    }
}
