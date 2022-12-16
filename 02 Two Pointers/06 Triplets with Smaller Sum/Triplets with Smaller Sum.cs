public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int len = nums.Length;
        int diff = int.MaxValue;
        Array.Sort(nums);
        for (int i = 0; i < len-2; i++) {
            int j = i + 1;
            int k = nums.Length-1;
            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];
                if (Math.Abs(sum - target) < Math.Abs(diff)) {
                    diff = sum - target;
                }
                if (sum < target) {
                    j++;
                }
                else {
                    k--;
                }
            }
            if (diff == 0)
                break;
        }
        return target + diff;
    }
}