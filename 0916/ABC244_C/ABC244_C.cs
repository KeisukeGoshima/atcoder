using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC_244_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var input = program.Read_int();
            var N = input[0];
            var number_list = Enumerable.Repeat(1, 2*N + 1).ToList();
            while (true)
            {
                var Takahashi = number_list.Select((x, index) => x * (index + 1)).Where(x => x != 0).Take(1).ToList();
                Console.WriteLine(Takahashi[0]);
                number_list[Takahashi[0] - 1] = 0;
                var input2 = program.Read_int();
                if (input2 == null) return ;
                var Aoki = input2[0];
                if (Aoki == 0) return ;
                number_list[Aoki - 1] = 0;
            }
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