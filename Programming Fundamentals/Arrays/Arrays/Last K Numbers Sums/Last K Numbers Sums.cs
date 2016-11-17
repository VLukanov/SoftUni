using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            
            var arr = new int[n];
            arr[0] = 1;

            for (int i = 1; i <= n-1; i++)
            {
                arr[i] = SumNums(arr,i - k, i - 1);
            }
            Console.WriteLine("Sequence: ");
            Console.WriteLine(String.Join(" ", arr));
        }

        static int SumNums(int[] arr,int startIndex, int endIndex)
        {
            int sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (sum >= 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
