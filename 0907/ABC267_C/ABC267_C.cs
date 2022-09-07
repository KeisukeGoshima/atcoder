using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC267C
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] S = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] A = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long num = 0;
            long add_sum = 0;
            for (int i=0; i < S[1]; i++)
            {
                num += A[S[0]-(i+1)] * (S[1] - i);
                add_sum += A[S[0]-(i+1)];
            }
            long max_num = num;
            for (int i=0; i < S[0] - S[1]; i++)
            {
                num -= S[1] * A[S[0]-(i+1)];
                add_sum += A[S[0] - i - S[1] - 1] - A[S[0] - i - 1];
                num += add_sum;
                if (max_num < num)
                    max_num = num;
            }
            Console.WriteLine(max_num);
        }
    }
}