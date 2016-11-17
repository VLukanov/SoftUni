using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Letters_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string items = Console.ReadLine().ToLower();
            var counts = new int[items.Max() + 1];

            for (int i = 0; i < items.Length; i++)
            {
                counts[items[i]]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{(char)i} -> {counts[i]}");
                }
                
            }
        }
    }
}
