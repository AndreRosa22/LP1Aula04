using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CountTo10();
            CountTo10();
            CountToN(3);
        }

        static void CountTo10()
        {
            CountToN(10);
        }
       
        static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
