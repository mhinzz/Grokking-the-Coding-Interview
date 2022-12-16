public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var result = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            int index = Math.Abs(nums[i])-1;
            if (nums[index] > 0)
                nums[index] = -nums[index];
            else
                result.Add(Math.Abs(nums[i]));
        }
        return result;
    }
}