namespace leetcode.easy;

public partial class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        int i = 0; int j = 1;
        int n = nums.Length;

        while (i < n && j < n) {
            if (nums[i] % 2 == 0) i += 2;
            else if (nums [j] % 2 == 1) j += 2;
            else {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i += 2; j += 2;
            }
        }

        return nums;
    }
}