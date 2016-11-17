using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            var frut = Console.ReadLine().ToLower();
            var dayOfWeek = Console.ReadLine().ToLower();
            var qutity = double.Parse(Console.ReadLine());
            var priceOfProduct = 1.0;
            var price = qutity * priceOfProduct;
            //плод banana  apple orange  grapefruit kiwi    pineapple grapes
            //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85


            if (dayOfWeek == "monday" ||
                dayOfWeek == "tuesday" ||
                dayOfWeek == "wednesday" ||
                dayOfWeek == "thursday" ||
                dayOfWeek == "friday")
            {
                if (frut == "banana")
                {
                    priceOfProduct = 2.50;
                }
                else if (frut == "apple")
                {
                    priceOfProduct = 1.20;
                }
                else if (frut == "orange")
                {
                    priceOfProduct = 0.85;
                }
                else if (frut == "grapefruit")
                {
                    priceOfProduct = 1.45;
                }
                else if (frut == "kiwi")
                {
                    priceOfProduct = 2.70;
                }
                else if (frut == "pineapple")
                {
                    priceOfProduct = 5.50;
                }
                else if (frut == "grapes")
                {
                    priceOfProduct = 3.85;
                }
                Console.WriteLine("{0:f2}", price * priceOfProduct);
            }
            else if ((dayOfWeek == "saturday" ||
                   dayOfWeek == "sunday"))
            {
                if (frut == "banana")
                {
                    priceOfProduct = 2.70;
                }
                else if (frut == "apple")
                {
                    priceOfProduct = 1.25;
                }
                else if (frut == "orange")
                {
                    priceOfProduct = 0.90;
                }
                else if (frut == "grapefruit")
                {
                    priceOfProduct = 1.60;
                }
                else if (frut == "kiwi")
                {
                    priceOfProduct = 3.00;
                }
                else if (frut == "pineapple")
                {
                    priceOfProduct = 5.60;
                }
                else if (frut == "grapes")
                {
                    priceOfProduct = 3.85;
                }
                Console.WriteLine("{0:f2}", price * priceOfProduct);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
