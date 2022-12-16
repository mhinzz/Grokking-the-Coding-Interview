public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        int j = i+1;
        if(nums.Length == 0) {
            return 0;
        }
        while(j < nums.Length) {
            if(nums[i] != nums[j]) {
                i++;
                nums[i] = nums[j];
            }
            j++;
        }
        return i+1;
    }
}