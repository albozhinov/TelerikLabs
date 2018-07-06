using System;
using System.Linq;

namespace ThreeGroups
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            var remainderZero = numbers.Where(x => x % 3 == 0).ToArray();
            var remainderOne = numbers.Where(x => x % 3 == 1).ToArray();
            var remainderTwo = numbers.Where(x => x % 3 == 2).ToArray();

            Console.WriteLine(string.Join(" ", remainderZero));
            Console.WriteLine(string.Join(" ", remainderOne));
            Console.WriteLine(string.Join(" ", remainderTwo));
        }
    }
}
