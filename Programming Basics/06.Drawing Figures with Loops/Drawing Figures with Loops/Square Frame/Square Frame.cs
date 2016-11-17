using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("- ", n);
            }
            Console.WriteLine("+");

            for (int ins = 0; ins < n-2; ins++)
            {
                Console.Write("| ");
                 for (int i = 0; i < n-2; i++)
                 {
                     Console.Write("- ", n);
                 }
                     Console.WriteLine("| ");
            }
           

            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ", n);
            }
            Console.WriteLine("+");
        }
    }
}
