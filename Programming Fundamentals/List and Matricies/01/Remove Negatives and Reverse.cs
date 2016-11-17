using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> items = new List<int>();
            foreach (var num in nums)
            {
                if (num >= 0)
                {
                    items.Add(num);
                }
            }
            items.Reverse();
            if (items.Count > 0)
            {
                Console.WriteLine(string.Join(" ", items));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
