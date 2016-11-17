using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            try
            {
                Console.Write("Enter even number: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    break;
                Console.WriteLine("The number is not even.");
            }
            catch
            {
                Console.WriteLine("Invalid number.");
            }

        }
    }
}
