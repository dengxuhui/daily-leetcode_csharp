using System;
using System.Collections.Generic;

namespace LeetcodeAnswer.Scripts
{
    public static class RabbitsAnswer
    {
        public static void Entry()
        {
            var cnt = NumRabbits(new int[] {1, 1, 2});
            Console.WriteLine("Rabbit Count is :{0}", cnt.ToString());
        }

        private static int NumRabbits(int[] answers)
        {
            // HashSet<int,int> s = ne
            HashSet<int> a = new HashSet<int>();
        }
    }
}