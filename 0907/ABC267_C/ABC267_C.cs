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
            var A = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var init_num = A.Where((x, index) => index < M - 1).Select((x, index) => x * (index + 2)).Sum();
            var init_sub_sum = A.Where((x, index) => index < M - 1).Select(x => x).Sum();
            long num = init_num;
            long sub_sum = init_sub_sum;
            var solve = A.Where((x, index) => index <= N - M).Select((x, index) => {
                num += M * A[index + M - 1];
                num -= init_sub_sum;
                init_sub_sum += A[index + M - 1];
                if (index != 0) init_sub_sum -= A[index - 1];
                return num;
            });
            Console.WriteLine(solve.Max());
        }
    }
}