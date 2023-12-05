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
            // Запрос у пользователя цифры
            Console.Write("Введите целое число для проверки на простоту: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Некорректные данные. Введите целое число!");
                Console.ReadLine();
                return;
            }

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
                Console.WriteLine($"{number} - простое число.");
            }
            else
            {
                Console.WriteLine($"{number} - не является простым числом.");
            }
            Console.ReadLine();
        }
    }
}
