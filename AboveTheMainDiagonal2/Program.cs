using System;

namespace AboveTheMainDiagonal2
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[,] matrix = new long[n, n];            

            var rows = n;
            var cols = n;
            long firstValue = 1;
            long value = 1;
            var divisor = n;

            for (long row = 0; row < rows; row++)
            {                
                for (long col = 0; col < cols; col++)
                {
                    matrix[row, col] = firstValue;                   
                    firstValue *= 2;

                    if (col == cols - 1)
                    {
                        value *= 2;
                        firstValue = value;
                    }                    
                }                
            }

            long sum = 0;
            var helper = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0 + helper; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
                helper++;
            }
            Console.WriteLine(sum);
        }
    }
}
