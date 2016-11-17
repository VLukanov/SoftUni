using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
           var n = int.Parse(Console.ReadLine());

            for (int col = 1; col <= n-1; col++)
            {
                for (int row = 1; row < n-col; row++)
                {
                    Console.Write(" ");
                }
                
                for (int row = 0; row < col; row++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            for (int col = n-1; col > 0; col--)
            {
                for (int row = 1; row < n-col; row++)
                {
                    Console.Write(" ");
                }
                
                for (int row = 0; row < col; row++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
