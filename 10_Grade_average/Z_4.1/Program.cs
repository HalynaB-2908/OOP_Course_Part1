using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char[] grades = new char[5];
            Console.WriteLine($"Введіть 5 оцінок (від A до F): ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Оцінка " + (i+1) + ": ");
                grades[i] = Console.ReadKey().KeyChar; 
                Console.WriteLine();
            }
            double sum = 0;
            for (int i = 0; i < 5; i++)
                switch (grades[i])
                {
                    case 'A':
                        sum += 10;
                        break;
                    case 'B':
                        sum += 9;
                        break;
                    case 'C':
                        sum += 8;
                        break;
                    case 'D':
                        sum += 7;
                        break;
                    case 'E':
                        sum += 6;
                        break;
                    case 'F':
                        sum += 5;
                        break;
                    default:
                        Console.WriteLine("Неправильно введено оцінку");
                        continue; 
                }
            double average = sum / 5;
            char averageGrade;
            if (average >= 9.5)
                averageGrade = 'A';
            else if (average >= 8.5)
                averageGrade = 'B';
            else if (average >= 7.5)
                averageGrade = 'C';
            else if (average >= 6.5)
                averageGrade = 'D';
            else
                averageGrade = 'F';

            Console.WriteLine("Середній бал:" + average + ";  оцінка: " + averageGrade);
        }
    }
}
