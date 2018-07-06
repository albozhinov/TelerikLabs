using System;

namespace P01
{
    class Program
    {
        static void Main()
        {
            
            var targets = long.Parse(Console.ReadLine());

            var georgeSpeed = long.Parse(Console.ReadLine());
            var georgeLatency = long.Parse(Console.ReadLine());

            var peterSpeed = long.Parse(Console.ReadLine());
            var peterLatency = long.Parse(Console.ReadLine());
            

            var georgreResult = (targets * georgeSpeed) + (2  * georgeLatency);
            var peterResult = (targets * peterSpeed) + (2 * peterLatency);

            if (georgreResult > peterResult)
            {
                Console.WriteLine("Peter");
            }
            else if (georgreResult < peterResult)
            {
                Console.WriteLine("George");
            }
            else if (georgreResult == peterResult)
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
