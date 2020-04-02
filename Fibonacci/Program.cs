using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNumber;
            int n;
            Console.WriteLine("Insira um número inteiro");
            userNumber = Console.ReadLine();
            n = Convert.ToInt32(userNumber);
            Console.WriteLine("O número na posição " + n + " é: ");
            Console.WriteLine(Fibonacci(n));
        }

        /// <summary>
        /// Method that show the number in the n positon of febonacci sequence
        /// </summary>
        /// <param name="n">Position number</param>
        /// <returns></returns>
        static int Fibonacci(int n)
        {
            int result = 0;

            if (n <= 2)
            {
                result = 1;
            }

            else
                result = Fibonacci(n - 1) + Fibonacci(n - 2);
            return result;
        }
    }
}
