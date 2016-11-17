using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] middleArr = new int[2 * k];
            int[] firstKelements = new int[k];
            int[] lastKelements = new int[k];

            for (int i = 0; i < middleArr.Length; i++)
            {
                middleArr[i] = numbers[k + i];                               
            }
            for (int i = 0; i < firstKelements.Length; i++)
            {                
                firstKelements[i] = numbers[i];                
            }
            for (int i = 0; i < lastKelements.Length; i++)
            {
                lastKelements[i] = numbers[i + 3 * k];
            }

            Array.Reverse(firstKelements);
            Array.Reverse(lastKelements);

            int[] firstLastKElements = new int[k * 2];

            for (int i = 0; i < firstLastKElements.Length; i++)
            {
                if (i < k)
                {
                    firstLastKElements[i] = firstKelements[i];
                }
                else
                {
                    firstLastKElements[i] = lastKelements[i - k];
                }
            }

            for (int i = 0; i < middleArr.Length; i++)
            {
                middleArr[i] += firstLastKElements[i]; 
            }

            Console.WriteLine( string.Join(" ", middleArr));
        }
    }
}
