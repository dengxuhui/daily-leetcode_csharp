using System;

namespace LeetcodeAnswer.Scripts
{
    public static class BinarySearchTrarget
    {
        public static void Entry()
        {
            //[2,5,6,0,0,1,2]
            //0
            var sourceData = new int[] { 2,5,6,1,1,1,2};
            var t = 5;
            var isExist = Search(sourceData, t);
            Console.WriteLine("Exist:" + isExist.ToString());
        }

        private static bool Search(int[] nums, int target)
        {
            //暴力搜索
            // for(var i = 0;i < nums.Length;i++){
            //     if(target == nums[i]){
            //         return true;
            //     }
            // }
            // return false;
            //二分查找
            int count = nums.Length;
            if (count == 0)
            {
                return false;
            }

            if (count == 1)
            {
                return nums[0] == target;
            }

            int low = 0, high = count - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    return true;
                }

                if (nums[low] == nums[mid] && nums[mid] == nums[high])
                {
                    low++;
                    high--;
                }
                else if (nums[low] <= nums[mid])
                {
                    if (nums[low] <= target && target < nums[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] < target && target <= nums[count - 1])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            return false;
        }
    }
}