using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                var sale = ReadSale();
                sales.Add(sale);
            }

            var towns = sales.Select(s => s.Town).OrderBy(t => t).Distinct().ToList();
            Console.WriteLine();

            foreach (var t in towns)
            {
                var salesForT = sales.Where(s => s.Town == t).Sum(s => s.Price * s.Quantity);
                
                Console.WriteLine("{0} -> {1:f2}", t, salesForT);
            }
        }

        public static Sale ReadSale()
        {
            var token = Console.ReadLine().Split(' ');
            var town = token[0];
            var product = token[1];
            var price = decimal.Parse(token[2]);
            var quantity = decimal.Parse(token[3]);
            var sale = new Sale() { Town = town, Product = product, Price = price, Quantity = quantity };
            return sale;
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

      
    }
}
