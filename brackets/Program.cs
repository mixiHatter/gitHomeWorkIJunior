using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "(()))(()";
            int rightB = 0;
            int leftB = 0;
            int depth = 0;

            foreach (int i in line)
            {
                System.Console.WriteLine(i);
                if (i == 40)
                {
                    rightB++;
                }
                else
                {
                    leftB++;
                }
            }
            Console.WriteLine(rightB + " " + leftB);
            Console.ReadKey();
        }
    }
}
