public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        List<int> subset = new List<int>();
        int count = (int)Math.Pow(2, nums.Length);
        for (int i = 0; i < count; i++) {
            for (int k = 0; k < nums.Length; k++) {
                if (((1 << k) & i) > 0)
                    subset.Add(nums[k]);
            }
            result.Add(new List<int>(subset));
            subset.Clear();
        }
        return result;
    }
}