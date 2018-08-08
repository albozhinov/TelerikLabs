using System;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int value = 1;

            //Added numbers
            for (int i = 0; i < N; i++)
            {                
                for (int k = 0; k < N; k++)
                {                    
                    matrix[i, k] = value + k + i;                    
                }                
            }
            // Print Matrix!
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    Console.Write(matrix[r,c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
