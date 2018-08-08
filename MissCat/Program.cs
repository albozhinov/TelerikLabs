using System;

namespace MissCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];
            int number;            

            for (int i = 0; i < N; i++)
            {
                number = int.Parse(Console.ReadLine());
                array[i] = number;
            }

            int counter = 0;
            int maxCounter = 0;
            int result = int.MaxValue;

            for (int i = 1; i <= 10; i++)
            {
                for (int k = 0; k < N; k++)
                {
                    if (array[k] == i)
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            result = i;                            
                        }
                        else if (counter == maxCounter && result > array[k])
                        {
                            result = array[k];                            
                        }                        
                    }
                }
                counter = 0;
            }
            Console.WriteLine(result);
        }
    }
}
