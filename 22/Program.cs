using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите соимость одной единицы товара");
            double k = Convert.ToDouble(Console.ReadLine());
            for (int i=2; i<=20; i++)
            {
                Console.WriteLine(i + "штук стоит" + i * k + "рублей");
            }
            Console.ReadKey();
        }
    }
}
