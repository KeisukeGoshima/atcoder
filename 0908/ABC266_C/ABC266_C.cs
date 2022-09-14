using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC266C
{
    class Program
    {
        const int positive = 1;
        const int negative = -1;
        static void Main(string[] args)
        {

            var A = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var B = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var C = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var D = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var calc = new Program();
            
            if (calc.calc_1(B.ElementAt(0), B.ElementAt(0), A, C) == calc.calc_1(D.ElementAt(0), D.ElementAt(0), A, C))
            {
                Console.WriteLine("No");
            }
            else
            {
                if (calc.calc_1(A.ElementAt(0), A.ElementAt(1), B, D) == calc.calc_1(C.ElementAt(0), C.ElementAt(0), B, D))
                    Console.WriteLine("No");
                else
                    Console.WriteLine("Yes");
            }
        }

        int calc_1(int x, int y, List<int> one, List<int> two)
        {
            float a = (two.ElementAt(0) - one.ElementAt(0)) * (y - one.ElementAt(1))
             - (two.ElementAt(1) - one.ElementAt(1)) * (x - one.ElementAt(0));
            if (a > 0)
                return positive;
            else
                return negative;
        }
    }
}