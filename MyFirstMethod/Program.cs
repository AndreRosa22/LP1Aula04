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
            CountTo10();
            CountToN(3);
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
    }
}
