using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ').ToArray();

            var revItems = items.Reverse();
            Console.WriteLine(string.Join(" ", revItems));
        }
    }
}
