using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var currentNum = 1;

            for (int i = 2; i <= num; i++)
            {                
                for (int a = 1; a <= i; a++)
                {
                    if (a > 1)
                    {                        
                        Console.Write(currentNum);
                        Console.Write(" ");
                        currentNum++;
                    }
                    if (currentNum > num)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (currentNum > num)
                {
                    break;
                }                
            }
            
        }
    }
}
