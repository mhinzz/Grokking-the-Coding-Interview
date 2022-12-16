public class Solution { // TODO
    public IList<IList<int>> FourSum(int[] nums, int target) {
        if(nums == null || nums.Length == 0) new List<IList<int>>();
        Array.Sort(nums);
        IList<IList<int>> res = new List<IList<int>>();
        for(int i = 0; i < nums.Length; i++) {
            for(int j = i + 1; j < nums.Length; j++) {
                int start = j + 1;
                int end = nums.Length - 1;
                int currentSum = nums[i] + nums[j];
                int diff = target - currentSum;
                while(start < end) {
                    int rem = nums[start] + nums[end];
                    if(rem == diff) {
                        var toAdd = new List<int>();
                        toAdd.Add(nums[start]);
                        toAdd.Add(nums[end]);
                        toAdd.Add(nums[i]); 
                        toAdd.Add(nums[j]);
                        res.Add(toAdd);
                        
                        while(start < end && nums[start] == toAdd[0]) 
                            ++start;
                        while(start < end && nums[end] == toAdd[1]) 
                            --end;
                    }
                    else if(rem < diff) {
                        start++;
                    }
                    else {
                        end--;
                    }
                }
                while(j + 1 < nums.Length && nums[j] == nums[j+1]) ++j;
            }
            while(i + 1 < nums.Length && nums[i] == nums[i+1]) ++i;
        }
        return res;
    }
}