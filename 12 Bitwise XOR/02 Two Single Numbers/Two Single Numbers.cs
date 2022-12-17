public class Solution {
    public int[] SingleNumber(int[] nums) {
        int[] res = new int[2];
        int count = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length;)
        {
            if (i < nums.Length - 1)
            {
                if (nums[i] == nums[i + 1])
                {
                    i += 2;
                    continue;
                }
                else
                {
                    res[count] = nums[i];
                    count++;
                    i++;
                }
            }
            else
            {
                res[count] = nums[nums.Length - 1];
                return res;
            }
            
        }
        return res;
    }
}