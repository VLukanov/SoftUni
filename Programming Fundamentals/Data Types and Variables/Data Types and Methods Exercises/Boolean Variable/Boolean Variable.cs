using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            
            try
            {
                Convert.ToBoolean(values);
                Console.WriteLine("Yes");
            }
            catch (Exception)
            {

                Console.WriteLine("No"); ;
            }
            
        }
    }
}
