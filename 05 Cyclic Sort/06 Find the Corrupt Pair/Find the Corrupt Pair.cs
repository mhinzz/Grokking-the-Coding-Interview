public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int len = nums.Length;
        HashSet<int> hset = new HashSet<int>(len);
        for (int i = 1; i <= len; i++)
            hset.Add(i);
        
        int[] result = new int[2];
        foreach (int n in nums)
            if (!hset.Remove(n))
                result[0] = n;
        result[1] = hset.First();
        
        return result;
    }
}