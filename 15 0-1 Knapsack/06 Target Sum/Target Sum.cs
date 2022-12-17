public class Solution {
    Dictionary<(int, int, int), int> memo = new Dictionary<(int, int, int), int>();
    
    public int FindTargetSumWays(int[] nums, int S) {
        return HowManyWays(nums, 0, nums.Length - 1, S);
    }
    
    private int HowManyWays(int[] nums, int left, int right, int sum) {
        if(memo.ContainsKey((left, right, sum)))
            return memo[(left, right, sum)];
        
        int res = 0;
        if(left == right) {
            if(nums[left] == sum || nums[left] == -1*sum)
                res = sum == 0 ? 2 : 1;
        }
        else
            res = HowManyWays(nums, left+1, right, sum-nums[left]) + HowManyWays(nums, left+1, right, sum+nums[left]);
        
        memo[(left, right, sum)] = res;
        return res;
    }
}