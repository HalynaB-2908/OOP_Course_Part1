using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_sentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть рядок зі словами: ");
            string input = Console.ReadLine();
            string word = "";
            int inputLength = input.Length;
            for (int i = 0; i < inputLength; i++)
            {
                char c = input[i];
                if (c == ' ')
                {
                    if (word.Length > 0)
                    {
                        Console.WriteLine(word);
                        word = "";
                    }
                }
                else
                    word += c;
            }
            if (word.Length > 0)
                Console.WriteLine(word);
        }
    }
}

