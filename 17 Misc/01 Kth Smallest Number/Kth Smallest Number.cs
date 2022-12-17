public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var minHeap = new SortedList<int,int>(Comparer<int>.Create(
            (x,y) => x == y ? 1: x.CompareTo(y)
        ));
        foreach(int num in nums) {
            minHeap.Add(num,num);
            if(minHeap.Count > k) {
                minHeap.RemoveAt(0);
            }
        }
        return minHeap.First().Key;
    }
}