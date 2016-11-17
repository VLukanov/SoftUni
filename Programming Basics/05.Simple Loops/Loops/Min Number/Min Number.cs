using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var minNum = int.MaxValue;
            for (int i = 0; i < num; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (minNum > currentNum)
                {
                    minNum = currentNum;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
