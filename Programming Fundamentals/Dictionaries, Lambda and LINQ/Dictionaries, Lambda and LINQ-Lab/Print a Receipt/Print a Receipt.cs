using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_a_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {            
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var sum = 0.00;
            Console.WriteLine(@"/----------------------\");
            foreach (var item in input)
            {
                Console.WriteLine("| {0,20:f2} |", item);
                sum += item;                
            }
            Console.WriteLine(@"|----------------------|");
            Console.WriteLine("| Total: {0,13:f2} |", sum);
            Console.WriteLine(@"\----------------------/");
        }
    }
}
