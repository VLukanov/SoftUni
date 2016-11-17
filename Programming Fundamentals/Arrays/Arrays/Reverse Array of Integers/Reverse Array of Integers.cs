using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int[] arr = new int[nums];

            for (int i = 0; i < nums; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());               
            }
            arr = arr.Reverse().ToArray();
            Console.Write(String.Join(", ", arr));
            Console.WriteLine();
            
        }
    }
}
