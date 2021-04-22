using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.32
            Console.WriteLine("Введите число");
            double n = Convert.ToDouble(Console.ReadLine());
            double s = 0;
            for (double i = 1; i <= n; i++)
            {
                s = s + 1.0 / i;
            }
            Console.WriteLine(n + "=" + s);
            Console.ReadKey();
        }
    }
}
