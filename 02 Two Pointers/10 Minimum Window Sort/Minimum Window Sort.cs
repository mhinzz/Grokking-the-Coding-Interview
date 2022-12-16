public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int max = int.MinValue;
        int right = -1;
        for (int i = 0; i < nums.Length; i++) {
            max = Math.Max(max, nums[i]);
            if (nums[i] < max) right = i;
        }
        if (right == -1) return 0;
        int min = int.MaxValue;
        int left = -1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            min = Math.Min(min, nums[i]);
            if (min < nums[i]) left = i;
        }
        return right - left + 1;
    }
}