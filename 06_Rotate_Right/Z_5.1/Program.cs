using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, temp;
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
            temp = mas1[N - 1];
            for (int i = N-1; i > 0; i--)
                mas1[i] = mas1[i-1];
            mas1[0] = temp;
            Console.WriteLine("елементи масиву після зсуву вправо:");
            for (int i = 0; i < N; i++)
                Console.Write(mas1[i] + " ");
            Console.ReadLine();
        }
    }
}
