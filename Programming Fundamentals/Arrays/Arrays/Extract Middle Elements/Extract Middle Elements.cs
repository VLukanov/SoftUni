using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = ExtractMiddleElements(numbers);

            Console.WriteLine(string.Join(", ", result));
        }

        static int[] ExtractMiddleElements(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return numbers;
            }
            if (numbers.Length % 2 == 0)
            {
                return new int[] {numbers[numbers.Length / 2 - 1], numbers[numbers.Length / 2] };
            }
            else
            {
                return new int[] { numbers[numbers.Length / 2 - 1], numbers[numbers.Length / 2], numbers[numbers.Length / 2 + 1] };
            }
        }
    }
}
