public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for (var i = 0; i < nums.Length;) {
            if (nums[i] > 0 && nums[i] <= nums.Length && nums[i] != nums[nums[i] - 1])
                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
            else i++;
        }

        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != i + 1) return i + 1;

        return nums.Length + 1;
    }
}