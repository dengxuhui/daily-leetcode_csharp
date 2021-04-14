using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LeetcodeAnswer.Scripts
{
    public class FindLargestNumber
    {
        public static void Entry()
        {
            LargestNumber(new int[] {3, 30, 34, 5, 9});
        }

        public static string LargestNumber(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return "";
            }

            Array.Sort(nums);
            var p = 10;
            var end = 0;
            var start = 0;
            while (end < nums.Length)
            {
                start = end;
                for (int i = start; i < nums.Length; i++)
                {
                    if (nums[i] / p > 0)
                    {
                        p *= 10;
                        break;
                    }

                    end++;
                }

                Array.Sort(nums, start, end - start);
                Array.Reverse(nums, start, end - start);
            }

            var v = string.Join("", nums);
            return v;
        }
    }
}