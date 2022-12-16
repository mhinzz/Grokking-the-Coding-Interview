public class Solution {
    public bool CircularArrayLoop (int[] nums) {
        int limit = 1000;
        int visitedForward = limit;
        int visitedBackward = -limit;
        
        for (int i = 0; i < nums.Length; i++) {
            if(isVisited(nums[i], limit))
                continue;
            bool isForward = nums[i] > 0;
            int nextPos = i;
            int visitFlag = isForward ? ++visitedForward : --visitedBackward; 
            do {
                nextPos = getNextPos(nums, nextPos, isForward, visitFlag);
            } while (nextPos > -1 && nextPos != i && !isVisited(nums[nextPos], limit));
            
            if (nextPos > -1 && (nextPos == i || nums[nextPos] == visitFlag))
                return true;
        }
        return false;
    }
    
    private bool isVisited (int val, int limit) {
        return Math.Abs(val) > limit;
    }
    
    private int getNextPos(int[] nums, int i, bool isForward, int visitFlag) {
        bool direction = nums[i] > 0;
        if (direction != isForward) 
            return -1;
        int next = (i + nums[i]) % nums.Length;
        if (next < 0) 
            next += nums.Length;
        nums[i] = visitFlag;
        return next == i ? -1 : next;
    }
}