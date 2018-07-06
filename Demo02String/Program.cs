using System;
using System.Text;

namespace Demo02String
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().ToCharArray();
            
            StringBuilder massage = new StringBuilder();

            for (int i = inputLine.Length - 1; i >= 0; i--)
            {
                if (Char.IsLetter(inputLine[i]))
                {
                    massage.Append(inputLine[i]);
                }
            }
            Console.WriteLine(massage.ToString());
        }
    }
}
