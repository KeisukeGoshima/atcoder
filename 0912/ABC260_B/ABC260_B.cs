using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC260_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var N = input[0];
            var X = input[1];
            var Y = input[2];
            var Z = input[3];
            var A = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var B = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var students = Enumerable.Range(1, N).Select(x => {
                Student student = new Student(x, A[x-1], B[x-1]);
                return student;
            }).ToList();
            var solve_X = students.OrderByDescending(x => x.Math).Select(x => x.Number).Take(X);
            var solve_Y = students.OrderByDescending(x => x.English).Where(x => solve_X.All(y => y != x.Number)).Select(x => x.Number).Take(Y);
            var solve_Z = students.OrderByDescending(x => x.Sum).Where(x => solve_X.All(y => y != x.Number) && solve_Y.All(z => z != x.Number)).Select(x => x.Number).Take(Z);
            var solve = solve_X.Concat(solve_Y).Concat(solve_Z);
            var output = solve.OrderBy(x => x);
            foreach (int num in output) Console.WriteLine(num);
        }
    }
    class Student
    {
        public int Number { get;}
        public int Math { get;}
        public int English { get;}
        public int Sum { get;}

        public Student(int number, int math, int english)
        {
            this.Number = number;
            this.Math = math;
            this.English = english;
            this.Sum = this.Math + this.English;
        }
    }
}