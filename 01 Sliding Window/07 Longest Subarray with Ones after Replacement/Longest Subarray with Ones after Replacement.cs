public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left =0, max_cons =0;
        for(int right=0; right < nums.Length; right++) {
            k+= nums[right]==0 ? -1 : 0;
            if(k < 0) {
                k+= nums[left]== 0 ? 1 : 0;
                left++; 
            }
            else {
                max_cons = Math.Max(max_cons, right-left+1);
            }
        }
        return max_cons;
    }
}