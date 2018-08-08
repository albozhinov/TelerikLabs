using System;

namespace Крачкомер
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles = int.Parse(Console.ReadLine());
            int meters = miles * 1609;
            Console.WriteLine(meters);
        }
    }
}
