using System;
using System.Collections.Generic;
using LeetcodeAnswer.Scripts;

namespace LeetcodeAnswer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start run...");
            
            //1.
            // DeleteRepeatNum.Entry();
            BinarySearchTrarget.Entry();
            
            // var dic = new Dictionary<int,string>();
            // dic[1] = "1";
            // dic[1] = "2";
            // dic.TryGetValue(1, out var str);
            // Console.WriteLine("out value is:" + str);
            // Console.WriteLine("dic cur count is:" + dic.Count);
            // NtfUglyNumber.Entry();
            // FindLargestNumber.Entry();
            
            // PrefixTree.Entry();
            LargestDivisibleSubset.Entry();
            Console.WriteLine("stop run...");
        }
    }
}