using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int col = 0; col < num; col++)
            {
                for (int row = 0; row < num; row++)
                {
                    var currentNum = col + row + 1;
                    
                    if (currentNum > num)
                    {
                        currentNum = 2 * num - currentNum;
                    }
                    Console.Write(currentNum + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
