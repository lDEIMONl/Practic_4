using System;

namespace Practic_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            string tokens = "fDha1234jaSBk1";
            string upperTokens = "";

            Console.WriteLine("Вывод коллекции без чисел: ");
            for (int i = 0; i < tokens.Length; i++)
            {
                if (Char.IsUpper(tokens[i]) && !Char.IsDigit(tokens[i]))
                {
                    upperTokens += tokens[i];
                }
                if (!Char.IsDigit(tokens[i]))
                {
                    Console.Write(tokens[i]);
                }
            }

            Console.WriteLine("\n\nВывод коллекции только с загалавнми буквами: \n" + upperTokens);
        }
    }
}
