public class Solution {
    private int FindSmallest(ref int[] nums) {
        var lo = 0;
        var hi = nums.Length - 1;
        
        while (lo <= hi) {
            var mid = (hi + lo) / 2;
            
            if (mid + 1 < nums.Length && nums[mid] > nums[mid + 1]) {
                return mid + 1;
            }
            
            if (nums[mid] >= nums[lo]) {
                lo = mid + 1;
            } else {
                hi = mid - 1;
            }
        }
        
        return 0;
    }
    
    private int BinarySearch(ref int[] nums, int target, int lo, int hi) {
        while (lo <= hi) {
            var mid = (hi + lo) / 2;
            
            if (nums[mid] == target) {
                return mid;
            } else if (nums[mid] > target) {
                hi = mid - 1;
            } else {
                lo = mid + 1;
            }
        }
        
        return -1;
    }
    
    public int Search(int[] nums, int target) {
        if (nums.Length < 1) {
            return -1;
        }
        
        if (nums.Length == 1) {
            return nums[0] == target ? 0 : -1;
        }
        
        var pivot = FindSmallest(ref nums);

        if (target == nums[pivot]) {
            return pivot;
        } else if (pivot > 0 && target > nums[nums.Length - 1]) {
            return BinarySearch(ref nums, target, 0, pivot - 1);
        } else {
            return BinarySearch(ref nums, target, pivot, nums.Length - 1);
        }
    }
}