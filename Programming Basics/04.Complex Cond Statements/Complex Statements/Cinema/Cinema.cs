using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfFilm = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());
            var price = 1.00;
            var places = row * col ;

            if (typeOfFilm == "premiere")
            {
                price = 12;
            }
            else if (typeOfFilm == "normal")
            {
                price = 7.50;                
            }
            else if (typeOfFilm == "discount")
            {
                price = 5;
            }
            Console.WriteLine("{0:f2}", places*price);
            Console.WriteLine("leva");
        }
    }
}
