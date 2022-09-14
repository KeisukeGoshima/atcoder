using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC267B
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            var S = input.Select(x => {
                if (x == '1') return 1;
                else return 0;
            }).ToList();
            int[] row = new int[]
            {
                S[6], S[3], S[7] + S[1], S[4] + S[0], S[8] + S[2], S[5], S[9]
            };
            if (S[0] == 1) 
            {
                Console.WriteLine("No");
                return ;
            }
            var down = row.Select((x, index) => index).Where(x => row[x] == 0).ToArray();
            var up = row.Select((x, index) => index).Where(x => row[x] > 0).ToArray();
            if (down.Count() == 0 || up.Count() == 0)
            {
                Console.WriteLine("No");
                return ;
            }
            if (down.Any(x => up.Min() < x && x < up.Max())) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }   
    }
}

