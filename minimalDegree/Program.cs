using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimalDegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree = 2;
            Random random = new Random();
            int minNumber = 4;
            int maxDegree = 600000000;
            int number = random.Next(minNumber, maxDegree);
            int countDegree = 2;
            int totalNumber = 4;

            while (totalNumber <= number)
            {
                totalNumber *= degree;
                countDegree++;
            }

            Console.WriteLine($"заданное число: {number}");
            Console.WriteLine($"степень: {countDegree}");
            Console.WriteLine($"{degree} в найденной степени: {totalNumber}");
            Console.ReadKey();
        }
    }
}
