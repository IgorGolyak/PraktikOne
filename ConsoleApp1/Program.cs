using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти сумму от 1 до числа а. а вводит пользовать
            Console.WriteLine("Введите число");
            double n = Convert.ToDouble(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }
            Console.WriteLine( s );
            Console.ReadKey();
        }
    }
}
