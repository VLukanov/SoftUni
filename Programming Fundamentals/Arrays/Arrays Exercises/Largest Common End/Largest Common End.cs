using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {      

        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();

            int smollerArr = Math.Min(arr.Length, arr1.Length);

            int leftCounter = CheckArr(smollerArr, arr, arr1);

            Array.Reverse(arr);
            Array.Reverse(arr1);

            int rightCounter = CheckArr(smollerArr, arr, arr1);

            Console.WriteLine(Math.Max(leftCounter, rightCounter));
            
        }

         static int CheckArr(int smollerArr, string[] arr, string[] arr1)
        {
            int counter = 0;
            for (int i = 0; i < smollerArr; i++)
            {
                if (arr[i] == arr1[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}
