public class Solution {
    public int[] SmallestRange(IList<IList<int>> nums) {
        PriorityQueue<int[], int> queue = new();
        int max = int.MinValue, range = int.MaxValue;
        for(int i = 0; i < nums.Count; i++){
            queue.Enqueue(new int[] { nums[i][0], i, 0 }, nums[i][0]);
            max = Math.Max(max, nums[i][0]);
            range = max-queue.Peek()[0];
        }
        int start = queue.Peek()[0], end = max;
        while(queue.Count == nums.Count){
            int[] item = queue.Dequeue();
            if((item[2]+1) < nums[item[1]].Count){
                int nextVal = nums[item[1]][item[2]+1];
                queue.Enqueue(new int[] { nextVal, item[1], item[2]+1 }, nextVal);
                max = Math.Max(max, nextVal);
                if(range > max-queue.Peek()[0]){
                    range = max-queue.Peek()[0];
                    start = queue.Peek()[0];
                    end = max;
                }
            }
        }
        return new int[] { start, end };
    }
}