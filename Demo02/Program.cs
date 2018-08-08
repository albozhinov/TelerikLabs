using System;
using System.Linq;

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var N = numbers[0].ToCharArray();
            var K = int.Parse(numbers[1]);

            N = N.Reverse().ToArray();
            string num = null;
            for (int i = 0; i < N.Length; i++)
            {
                num += N[i];
            }

            int result = int.Parse(num);
            int pass = (result / K) + (result % K);
            Console.WriteLine(pass);
        }
    }
}
