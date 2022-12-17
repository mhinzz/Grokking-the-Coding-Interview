public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>(nums));
        int len = nums.Length;
        while (true) {
            List<int> perm = new List<int>(nums);
            int j = len - 2;
            while (j >= 0 && perm[j] >= perm[j+1]) 
                j--;
            if (j < 0) 
                break;
            int l = len - 1;
            while (perm[j] >= perm[l]) 
                l--;
            (perm[j], perm[l]) = (perm[l], perm[j]);
            int k = j + 1;
            l = len - 1;
            while (k < l) {
                (perm[k], perm[l]) = (perm[l], perm[k]);
                k++;
                l--;
            }
            result.Add(perm);
            nums = perm.ToArray();
        }
        return result;
    }
}