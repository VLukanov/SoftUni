using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var maxNum = int.MinValue;
            for (int i = 0; i < num; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (maxNum < currentNum)
                {
                    maxNum = currentNum;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
