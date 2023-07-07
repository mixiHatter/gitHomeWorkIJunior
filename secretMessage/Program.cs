using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secretMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "Valera";
            string secretMessage = "Ты самый лучший! У тебя всё получиться!";
            string userInput;
            int numberOfTries = 3;

            for (int i = numberOfTries; i > 0; i--)
            {
                Console.WriteLine("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine(secretMessage);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно!");
                }
            }
        }
    }
}
