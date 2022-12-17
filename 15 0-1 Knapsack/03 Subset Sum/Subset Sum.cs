public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int len = nums.Length;
        int count = 0;
        int sum = 0;
        Dictionary<int,int> dict = new Dictionary<int,int>() { { 0, 1} };
        
        for (int i = 0; i < len; i++) {
            sum += nums[i];
                        
            if (dict.ContainsKey(sum - k))
                count += dict[sum-k];
            
            if (!dict.ContainsKey(sum))
                dict.Add(sum, 1);
            else
                dict[sum]++;
        }
        
        return count;
    }
}