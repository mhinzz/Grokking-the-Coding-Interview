public class Solution {
    public int FindDuplicate(int[] nums) {
        var slow = nums[0];
        var fast = nums[0];
        while (fast <= nums.Length - 1 && slow <= nums.Length - 1) {
            slow = nums[slow];
            fast = nums[nums[fast]];
            if (fast == slow) break;
        }
        slow = nums[0];
        while (slow != fast) {
            slow = nums[slow];
            fast = nums[fast];
        }
        return fast;
    }
}