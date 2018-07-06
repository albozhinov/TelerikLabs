using System;
using System.Linq;
using System.Collections.Generic;

namespace P03
{
    class Program
    {
        static void Main()
        {
            var inputNums = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToList();
            
            var result = new List<int>();

            for (int i = 1; i <= inputNums.Count; i++)
            {
                if (!inputNums.Contains(i))
                {
                    result.Add(i);
                }
            }            
            Console.WriteLine(string.Join(",", result));
        }
    }
}
