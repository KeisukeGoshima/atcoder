using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC266C
{
    class Program
    {
        const int POSITIVE = 1;
        const int NEGATIVE = -1;
        static void Main(string[] args)
        {
            var program = new Program();
            var A = program.SetPosition();
            var B = program.SetPosition();
            var C = program.SetPosition();
            var D = program.SetPosition();            
            
            if (program.Calc(B[0], B[1], A, C) == program.Calc(D[0], D[1], A, C))
            {
                Console.WriteLine("No");
            }
            else
            {
                if (program.Calc(A[0], A[1], B, D) == program.Calc(C[0], C[1], B, D))
                    Console.WriteLine("No");
                else
                    Console.WriteLine("Yes");
            }
        }

        List<int> SetPosition()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        }

        int Calc(int x, int y, List<int> one, List<int> two)
        {
            float a = (two[0] - one[0]) * (y - one[1])
             - (two[1] - one[1]) * (x - one[0]);
            if (a > 0)
                return POSITIVE;
            else
                return NEGATIVE;
        }
    }
}