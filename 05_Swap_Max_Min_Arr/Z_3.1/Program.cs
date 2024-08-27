using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Max_Min_Arr
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
            HashSet<int> uniqueNumbers = new HashSet<int>();
            for (int i = 0; i < N;)
            {
                int randomNumber = myR.Next(20);
                if (uniqueNumbers.Add(randomNumber))
                {
                    mas1[i] = randomNumber;
                    Console.Write(mas1[i] + " ");
                    i++;
                }
            }
            Console.WriteLine();
            int max, min, iMax = 0, iMin = 0, temp;
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
            temp = mas1[iMin];
            mas1[iMin] = mas1[iMax];
            mas1[iMax] = temp;
            Console.WriteLine("змінені місцями мінімум та максимум: ");
            for (int i = 0; i < N; i++)
                Console.Write(mas1[i] + " ");
            Console.ReadLine();
        }
    }
}
