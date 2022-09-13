using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC260_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var X = input[1];
            var Y = input[2];
            var Z = input[3];
            List<Student> students = new List<Student>();
            var A = Console.ReadLine().Split(' ').Select(int.Parse);
            var B = Console.ReadLine().Split(' ').Select(int.Parse);
            //LINQでclassの各要素に代入してリスト化するやり方がわかりません。
            for (int i = 0; i < N; i++)
            {
                Student student = new Student();
                student.number = i + 1;
                student.math = A.ElementAt(i);
                student.english = B.ElementAt(i);
                student.sum = student.math + student.english;
                students.Add(student);
            }
            var solve_X = students.OrderByDescending(x => x.math).Select(x => x.number).Take(X);
            var solve_Y = students.OrderByDescending(x => x.english).Where(x => solve_X.All(y => y != x.number)).Select(x => x.number).Take(Y);
            var solve_Z = students.OrderByDescending(x => x.sum).Where(x => solve_X.All(y => y != x.number) && solve_Y.All(z => z != x.number)).Select(x => x.number).Take(Z);
            var solve = solve_X.Concat(solve_Y).Concat(solve_Z);
            var output = solve.OrderBy(x => x);
            foreach (int num in output) Console.WriteLine(num);
        }
    }
    class Student
    {
        public int number { get; set; }
        public int math { get; set; }
        public int english { get; set; }
        public int sum { get; set; }
    }
}