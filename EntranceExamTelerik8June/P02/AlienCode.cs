using System;

namespace P02
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = "";
            char letter;
            int currLetter;

            for (int i = 0; i < input.Length / 2; i++)
            {
                currLetter = Math.Abs(input[i] - input[input.Length - 1 - i]) + 'a';
                if (input[i] == ' ' || input[input.Length - 1 - i] == ' ')
                {
                    result += " ";
                    continue;
                }
                else if (input[i] == '-' || input[input.Length - 1 - i] == '-')
                {
                    result += "-";
                    continue;
                }                

                letter = (char)currLetter;
                result += letter;
               
            }
            if (input.Length % 2 != 0)
            {
                currLetter = input.Length / 2;
                letter = input[currLetter];
                result += letter;
            }
            Console.WriteLine(result);
        }
    }
}
