using System;
using leetcode.Algorithm;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Start..");
            //new[] {new[] {1, 3, 4, 7}, new[] {10, 11, 16, 20}, new[] {23, 30, 34, 60}}
            SearchMatrix.Entry(new[] {new[] {1, 3, 4, 7},  new[] {23, 30, 34, 60}}, 34);
            Console.WriteLine("Stop..");
        }
    }
}