using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_words
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть рядок: ");
            string input = Console.ReadLine();
            int wordCount = 0;
            bool inWord = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (!inWord)
                    {
                        wordCount++;
                        inWord = true;
                    }
                }
                else
                    inWord = false;
            }
            Console.WriteLine($"Кількість слів: {wordCount}");
        }
    }
}

