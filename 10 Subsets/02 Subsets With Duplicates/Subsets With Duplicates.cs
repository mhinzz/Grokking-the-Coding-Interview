public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> results = new();
        Backtrack(0, new List<int>());
        return results;
        void Backtrack(int index, List<int> currentSubset) {
            if (index >= nums.Length) {
                results.Add(currentSubset.ToArray());
                return;
            }
            currentSubset.Add(nums[index]);
            Backtrack(index + 1, currentSubset);
            currentSubset.RemoveAt(currentSubset.Count - 1);
            while (index < nums.Length - 1 && nums[index] == nums[index + 1]) {
                index++;
            }
            Backtrack(index + 1, currentSubset);
        }
    }
}