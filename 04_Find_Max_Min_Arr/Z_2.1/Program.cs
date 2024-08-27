using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Max_Min_Arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] mas1;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("-> N:  ");
            N = Convert.ToInt32(Console.ReadLine());
            mas1 = new int[N];
            Random myR = new Random();
            Console.WriteLine("елементи масиву:");
            for (int i = 0; i < N; i++)
            {
                mas1[i] = myR.Next(10);
                Console.Write(mas1[i] + " ");
            }
            Console.WriteLine();
            int max, min, iMax = 0, iMin = 0;
            max = mas1[0];
            min = mas1[0];
            for (int i = 1; i < mas1.Length; i++)
            {
                if (mas1[i] > max)
                {
                    max = mas1[i];
                    iMax = i;
                }
                if (mas1[i] < min)
                {
                    min = mas1[i];
                    iMin = i;
                }
            }
            Console.WriteLine("максимальний елемент  №" + iMax + " = " + max);
            Console.WriteLine("мінімальний елемент  №" + iMin + " = " + min);
        }
    }
}
