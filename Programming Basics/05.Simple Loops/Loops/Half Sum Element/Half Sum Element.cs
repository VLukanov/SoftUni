using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxNum = int.MinValue;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (maxNum < num)
                {
                    maxNum = num;
                }
            }
            if (sum - maxNum == maxNum)
            {
                Console.WriteLine($"Yes Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(maxNum + -(sum - maxNum))}");
            }
        }
    }
}
