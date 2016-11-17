using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                for (int row = 1; row <= i; row++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine("$ ", n);
            }
        }
    }
}
