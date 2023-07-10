using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineInput = "(()))(()";
            string[] lineArray;
            int countRightBracket = 0;
            int countLeftBracket = 0;
            int rightBracket = 40;
            int leftBracket = 41;

            int depth = 0;
            bool correctString = false;
            

            foreach (var symbol in lineInput)
            {
                lineArray += symbol;
                Console.WriteLine(symbol);
            }

            Console.WriteLine(lineArray);
            Console.ReadKey();
        }
    }
}
