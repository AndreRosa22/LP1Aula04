using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CountTo10();
            CountToN(3);
            CountToN(-1, 5);
        }

        /// <summary>
        /// Method that prints Numbers from 1 to 10
        /// </summary>
        static void CountTo10()
        {
            CountToN(10);
        }
       
        /// <summary>
        /// Method that prints Numbers from 1 to n
        /// </summary>
        /// <param name="n">Maximum number to print</param>
        static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void CountToN(int n1, int n2)
        {
            for(int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
