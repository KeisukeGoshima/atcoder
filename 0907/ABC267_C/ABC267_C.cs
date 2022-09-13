using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC267C
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = S[0];
            var M = S[1];
            var A = Console.ReadLine().Split(' ').Select(long.Parse);
            long num = 0;
            long add_sum = 0;
            for (int i=0; i < S[1]; i++)
            {
                num += A.ElementAt(N-(i+1)) * (M - i);
                add_sum += A.ElementAt(N-(i+1));
            }
            long max_num = num;
            for (int i=0; i < S[0] - S[1]; i++)
            {
                num -= M * A.ElementAt(N-(i+1));
                add_sum += A.ElementAt(N - i - M - 1) - A.ElementAt(N - i - 1);
                num += add_sum;
                if (max_num < num)
                    max_num = num;
            }
            Console.WriteLine(max_num);
        }
    }
}