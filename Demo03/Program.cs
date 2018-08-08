using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(' ').ToArray();

            int maxWordLenght = 0;

            if (inputWords.Length > 1)
            {
                maxWordLenght = SearchMaxLenght(inputWords);
            }
            else
            {
                maxWordLenght = inputWords[0].Length;
            }

            ReturnEqualsWordsLenght(inputWords, maxWordLenght);
            string message = GetLetter(inputWords, maxWordLenght);

            string result = RotateLetters(message);

            Console.WriteLine(result);            
        }

        private static string RotateLetters(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(message);
            
            int countOfRotate;
            int index = 0;
            
            message = message.ToLower();
            
            for (int i = 0; i < message.Length; i++)
            {
                var toLower = sb[i].ToString().ToLower();
                char newChar = char.Parse(toLower);
                char letter = sb[i];

                countOfRotate = newChar - '`';               

                index = (countOfRotate + i) % sb.Length;

                sb.Remove(i, 1);
                sb.Insert(index, letter);
                
            }
            return sb.ToString();
        }

        private static string GetLetter(string[] inputWords, int maxLenght)
        {
            StringBuilder sb = new StringBuilder();

            for (int letter = maxLenght - 1; letter >= 0 ; letter--)
            {
                for (int i = 0; i < inputWords.Length; i++)
                {
                    string currWord = inputWords[i];

                    if (currWord[letter] != '!')
                    {
                        sb.Append(currWord[letter]);
                    }

                }
            }
            return sb.ToString();          
        }

        private static void ReturnEqualsWordsLenght(string[] words, int maxLenght)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != maxLenght)
                {
                    int diff = Math.Abs(words[i].Length - maxLenght);
                    for (int k = 0; k < diff; k++)
                    {
                        words[i] = words[i].Insert(0, "!");
                    }
                }
            }
        }

        private static int SearchMaxLenght(string[] words)
        {
            int lenght = 0;
            int bestLengh = 0;

            for (int i = 1; i < words.Length; i++)
            {
                lenght = Math.Max(words[i - 1].Length, words[i].Length);
                if (lenght > bestLengh)
                {
                    bestLengh = lenght;
                }
            }
            return bestLengh;
        }
    }
}
