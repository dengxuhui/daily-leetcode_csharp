﻿namespace leetcode.Algorithm
{
    public static class SearchMatrix
    {
        /**
         * *
编写一个高效的算法来判断 m x n 矩阵中，是否存在一个目标值。该矩阵具有如下特性：

每行中的整数从左到右按升序排列。
每行的第一个整数大于前一行的最后一个整数。
https://leetcode-cn.com/problems/search-a-2d-matrix/
         */
        public static bool Entry(int[][] matrix, int target)
        {
            int rowIndex = BinarySearchFirstColumn(matrix, target);
            if (rowIndex < 0)
            {
                return false;
            }

            return BinarySearchRow(matrix[rowIndex], target);
        }

        private static int BinarySearchFirstColumn(int[][] matrix, int target)
        {
            int low = -1, high = matrix.Length - 1;
            while (low < high)
            {
                int mid = (high - low + 1) / 2 + low;
                if (matrix[mid][0] <= target)
                {
                    low = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low;
        }

        private static bool BinarySearchRow(int[] row, int target)
        {
            int low = 0, high = row.Length - 1;
            while (low <= high)
            {
                int mid = (high - low) / 2 + low;
                if (row[mid] == target)
                {
                    return true;
                }

                if (row[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return false;
        }
    }
}