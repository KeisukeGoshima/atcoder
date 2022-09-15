using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC268_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();
            if (T.StartsWith(S)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}