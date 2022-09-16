using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC_244_B
{
    class Program
    {
        static void Main(string [] args)
        {
            var program = new Program();
            var input = program.Read_int();
            if (input == null) return ;
            var N = input[0];
            var T = Console.ReadLine().ToList();
            var index = 0;
            var solve = T.Select(x => {
                if (x == 'R')
                {
                    index++;
                    if (index == 4) index = 0;
                    return -1;
                }
                else
                    return index;
            }).ToList();
            var east = solve.Where(x => x == 0).Count();
            var south = solve.Where(x => x == 1).Count();
            var west = solve.Where(x => x == 2).Count();
            var north = solve.Where(x => x == 3).Count();
            Console.WriteLine("{0} {1}", east - west, north - south);
        }
        List<int> Read_int()
        {
            var check = new List<bool>();
            var input = Console.ReadLine().Split(' ').Select(x => {
                var temp = 0;
                check.Add(int.TryParse(x, out temp));
                return temp;
            }).ToList();
            if (check.Any(x => x == false)) return null;
            return input;
        }
    }
}