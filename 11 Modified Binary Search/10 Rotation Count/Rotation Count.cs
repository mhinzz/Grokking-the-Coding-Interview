public class Solution {
    public int FindMin(int[] nums) {
        int i = 0;
        int j = nums.Length-1;
        if (nums[i] > nums[j]) {
             while (i < j) {
                int mid = i + (j - i) / 2;
                if (nums[mid] > nums[j])
                    i = mid + 1;
                else
                    j = mid;
            }
        }
        return nums[i];
    }
}