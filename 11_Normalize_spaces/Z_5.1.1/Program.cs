using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normalize_spaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть рядок з реченнями: ");
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];

                if (input[i] == '.' && i + 1 < input.Length && input[i + 1] != ' ')
                    result += ' ';

                if (input[i] == '.' && i + 1 < input.Length && input[i + 1] == ' ')
                    while (input[i + 2] == ' ')
                        i++;                
            }
            Console.WriteLine("Виправлений рядок: ");
            Console.WriteLine(result);
        }
    }
}


