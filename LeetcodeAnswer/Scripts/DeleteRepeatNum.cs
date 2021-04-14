using System;

namespace LeetcodeAnswer.Scripts
{
    public static class DeleteRepeatNum
    {
        public static void Entry()
        {
            var array = new[] {1, 1, 1, 2, 3, 3, 3, 4, 2, 1, 0, 1, 0};
            int leftCnt = RemoveDuplicates(array);
            Console.WriteLine("Left cnt:" + leftCnt);
            Console.WriteLine("Array is=>" + string.Join(",", array));
        }

        private static int RemoveDuplicates(int[] nums)
        {
            int count = nums.Length;
            if (count <= 2)
            {
                return count;
            }

            int slowPtr = 2, fastPtr = 2;
            while (fastPtr < count)
            {
                if (nums[slowPtr - 2] != nums[fastPtr])
                {
                    nums[slowPtr] = nums[fastPtr];
                    slowPtr++;
                }

                fastPtr++;
            }

            return slowPtr;
        }
    }
}