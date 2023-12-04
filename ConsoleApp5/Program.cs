using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;
            }

            if (isPrime && number > 1)
            {
                Console.WriteLine($"{number} - простое число");
            }
            else
            {
                Console.WriteLine($"{number} - не является простым числом");
            }
            Console.ReadKey();
        }
    }
}
