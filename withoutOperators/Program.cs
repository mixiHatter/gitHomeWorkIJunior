using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace withoutOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMin = 1;
            int numberMax = 27;
            int minNumberCheck = 100;
            int maxNumberCheck = 999;
            int count = 0;
            Random random = new Random();
            int number = random.Next(numberMin, numberMax +1);

            Console.WriteLine($"Число N = {number}");

            for(int i = minNumberCheck; i <= maxNumberCheck; i += 1)
            {
                for (int j = number; j <= maxNumberCheck; j += number)
                {
                    if (j == i)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Количество трёхзначных натуральных чисел кратны N = {count}");
            Console.ReadKey();
        }
    }
}