using System;
using System.Linq;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "git is a <<version control>> system for tracking changes in <<computer files>> and cordinating work on those files among multiple people";

            string[] array = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();            

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains("<<"))
                {
                   array[i] = array[i].Remove(0, 2);
                   array[i] = array[i].ToUpper();
                }
                else if (array[i].Contains(">>"))
                {
                    array[i] = array[i].TrimEnd('>');
                    array[i] = array[i].ToUpper();
                }
            }            
            Console.WriteLine(string.Join(" ", array));
        }        
    }
}
