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
                int nums = int.Parse(Console.ReadLine());
                int[] arr = new int[nums];

                for (int i = 0; i < nums; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int sum = 0;
                int min = arr[0];
                int max = int.MinValue;


                for (int i = 0; i < nums; i++)
                {
                    sum += arr[i];
                    if (arr[i] < min)
                    {
                        arr[i] = min;
                    }
                    max = Math.Max(max, arr[i]);
                }
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Min = " + min);
                Console.WriteLine("Max = " + min);
                Console.WriteLine("First = " + arr[0]);
                Console.WriteLine("Last = " + arr[arr.Length - 1]);
                Console.WriteLine("Average = " + (double)sum / nums);
            }
        }
    }


    
