﻿namespace leetcode.easy;

public partial class Solution
{
    public int SumOfSquares(int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums.Length % (i + 1) == 0)
                sum += (nums[i] * nums[i]);
        }

        return sum;
    }
}
