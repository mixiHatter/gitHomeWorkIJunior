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
            int numberMax = 28;
            int minNumberCheck = 100;
            int maxNumberCheck = 999;
            int count = 0;
            Random random = new Random();
            int N = random.Next(numberMin, numberMax);

            Console.WriteLine($"Число N = {N}");

            for(int i = minNumberCheck; i <= maxNumberCheck; i += 1)
            {
                for (int j = N; j <= maxNumberCheck; j += N)
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