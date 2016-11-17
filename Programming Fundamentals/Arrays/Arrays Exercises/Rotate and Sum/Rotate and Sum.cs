using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sumOfRotations = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = numbers[numbers.Length - 1];

                for (int a = numbers.Length - 1; a >= 0; a--)
                {
                    numbers[a] = numbers[a - 1];
                }
                numbers[0] = lastElement;

                for (int a = 0; a < numbers.Length; a++)
                {
                    sumOfRotations[a] += numbers[a];
                }
            }

            Console.WriteLine(string.Join(" ", sumOfRotations));
        }
    }
}
