using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}. You are {2} years old.", firstname, lastName, age);

        }
    }
}
