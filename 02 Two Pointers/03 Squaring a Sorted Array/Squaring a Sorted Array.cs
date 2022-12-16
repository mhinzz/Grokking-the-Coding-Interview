public class Solution {
    public int[] SortedSquares(int[] nums) {
        var arr = new int[nums.Length];
        int begIndex = 0;
        int endIndex = nums.Length-1;
        int end = endIndex;
        while (begIndex <= endIndex) {
            arr[end--] = Math.Abs(nums[endIndex]) > Math.Abs(nums[begIndex])
                ? nums[endIndex] * nums[endIndex--]
                : nums[begIndex] * nums[begIndex++];
        }
        return arr;
    }
}