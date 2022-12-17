public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        int len = nums.Length;
        int[] dp = new int[target+1];
        dp[0] = 1;
        Array.Sort(nums);
        for (int i = 1; i <= target; i++) {
            for (int j = 0; j < len; j++) {
                if (nums[j] <= i)
                    dp[i] += dp[i - nums[j]];
                else
                    break;
            }
        }
        return dp[target];
    }
}