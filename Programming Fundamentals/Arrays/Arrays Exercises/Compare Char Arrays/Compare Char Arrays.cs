using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

           // string[] arr = { new string(firstArr), new string(secondArr) };
           // Console.WriteLine(string.Join("\n", arr.OrderBy(str => str)));

            int smollerArr = Math.Min(firstArr.Length, secondArr.Length);
            bool equal = false;

            for (int i = 0; i < smollerArr; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    continue;
                }
                else
                {
                    if (firstArr[i] < secondArr[i])
                    {
                        Console.WriteLine(firstArr);
                        Console.WriteLine(secondArr);
                    }
                    else
                    {
                        Console.WriteLine(secondArr);
                        Console.WriteLine(firstArr);                        
                    }
                    equal = true;
                    break;
                }
            }
            if (!equal)
            {
                if (firstArr.Length <= secondArr.Length)
                {
                    Console.WriteLine(firstArr);
                    Console.WriteLine(secondArr);
                }
                else
                {
                    Console.WriteLine(secondArr);
                    Console.WriteLine(firstArr);
                }
            }
        }
    }
}
