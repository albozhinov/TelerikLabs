using System;
using System.Numerics;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var result = Factorial(N);
            Console.WriteLine(result);
        }

        private static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;                
            }
            return factorial;
        }
    }
}
