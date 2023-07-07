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
            int minDegree = 4;
            int maxDegree = 600000000;
            int number = random.Next(minDegree, maxDegree);
            int count = 1;

            while (degree <= number)
            {
                degree += degree;
                count++;
            }

            Console.WriteLine($"заданное число: {number}");
            Console.WriteLine($"степень: {count}");
            Console.WriteLine($"2 в найденной степени: {degree}");
            Console.ReadKey();
        }
    }
}
