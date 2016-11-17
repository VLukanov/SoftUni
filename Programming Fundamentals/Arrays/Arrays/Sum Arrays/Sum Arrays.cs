using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var longerArr = Math.Max(arr.Length, arr1.Length);
            var result = new int[longerArr];

            for (int i = 0; i < longerArr; i++)
            {
                result[i] = arr[i % arr.Length] + arr1[i % arr1.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
