using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var qantity = double.Parse(Console.ReadLine());         


            if (product == "coffee")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(qantity * 0.5);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(qantity * 0.4);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(qantity * 0.45);
                }
            }
            else if (product == "beer")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(qantity * 1.2);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(qantity * 1.15);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(qantity * 1.1);
                }
            }
            else if (product == "water")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(qantity * 0.8);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(qantity * 0.7);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(qantity * 0.7);
                }
            }
            else if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(qantity * 1.45);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(qantity * 1.30);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(qantity * 1.35);
                }
            }
            else if (product == "peanuts")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(qantity * 1.6);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(qantity * 1.5);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(qantity * 1.55);
                }
            }
        }
    }
}
