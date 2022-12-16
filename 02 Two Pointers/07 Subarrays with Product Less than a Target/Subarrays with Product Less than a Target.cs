public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if (k == 0 || k == 1) {
            return 0;
        }
        int len = nums.Length;
        if (len == 0) {
            return 0;
        }
        if (len == 1) {
            return (nums[0] < k) ? 1 : 0;
        }
        
        int count = 0;
        int i = 0;
        int j = 1;
        int product = nums[0];
        while (i < len && j <= len) {
            if (product < k) {
                count += (j-i);
                if (j == len) {
                    break;
                }
                product *= nums[j++];
            }
            else {
                product /= nums[i++];
            }
        }
        return count;
    }
}