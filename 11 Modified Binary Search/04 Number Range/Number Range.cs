public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] ans = {-1, -1};
        ans[0] = BinarySearch(nums, target, true);
        if(ans[0] != -1)
            ans[1] = BinarySearch(nums, target, false);
        return ans;
    }
    
    int BinarySearch(int[] nums,int target, bool firstStartIndex) {
        int ans = -1;
        int start = 0;
        int end = nums.Length - 1;
        while(start <= end) {
            int mid = start + (end - start)/2;
            if(nums[mid] < target)
                start = mid+1;
            else if(nums[mid] > target)
                end = mid-1;
            else {
                ans = mid;
                if(firstStartIndex) {
                    end = mid -1;      
                }
                else {
                    start = mid + 1;
                }
            }
        }
        return ans;
    }
}