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
            Random rand = new Random();
            int number = rand.Next(4, 101);
            int count = 1;

            for(int i = degree; i <= number; i += i)
            {
                degree += i;
                count++;
            }

            Console.WriteLine($"заданное число: {number}");
            Console.WriteLine($"степень: {count}");
            Console.WriteLine($"2 в найденной степени: {degree}");
            Console.ReadKey();
        }
    }
}
