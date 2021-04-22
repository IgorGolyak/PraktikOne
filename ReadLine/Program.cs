using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.14
            Console.WriteLine("Введите число");
            double n = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i<=9; i++)
            {
                Console.WriteLine(i + " * " + n + " = " + i * n);
            }
            Console.ReadKey();

        }
    }
}
