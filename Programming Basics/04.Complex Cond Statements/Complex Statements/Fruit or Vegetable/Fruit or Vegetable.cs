using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            // banana, apple, kiwi, cherry, lemon и grapes
            if (product == "banana" ||
                product == "apple" ||
                product == "kiwi" ||
                product == "cherry" ||
                product == "lemon" ||
                product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            // "vegetable" са tomato, cucumber, pepper и carrot
            else if (product == "tomato" ||
                product == "cucumber" ||
                product == "pepper" ||
                product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
