public class Solution {
    public double[] MedianSlidingWindow(int[] nums, int k) {
        double[] res = new double[nums.Length - k + 1];
        List<int> list = new List<int>();
        for(int i = 0; i < k; i++){
            list.Add(nums[i]);
        }
        list.Sort();
        res[0] = (k % 2 == 0) ? 
            (
                Decimal.ToDouble(list[k / 2 - 1]) + 
                Decimal.ToDouble(list[k / 2])
            ) / 2 : 
            list[k / 2];
        for(int i = 0; i < nums.Length - k; i++){
            int left = nums[i];
            int right = nums[i+k];
            int index = list.BinarySearch(right);
            if (index >= 0) list.Insert(index, right);
            else list.Insert(-index - 1,right);
            index=list.BinarySearch(left);
            list.RemoveAt(index);
            res[i + 1] = (k % 2 == 0) ? 
                (
                    Decimal.ToDouble(list[k / 2 - 1]) +
                    Decimal.ToDouble(list[k / 2])
                ) / 2 : 
                list[k / 2];
        }
        return res;
    }
}