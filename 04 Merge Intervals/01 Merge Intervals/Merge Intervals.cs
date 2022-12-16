public class Solution {
    public int[][] Merge(int[][] intervals) {
        intervals = intervals.OrderBy(a => a[1]).OrderBy(a => a[0]).ToArray();
        int start = int.MaxValue;
        int end = 0;
        List<int[]> result = new List<int[]>();
        int count = intervals.Length;
        for (int i = 0; i < count; i++) {
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            if (i == count-1 || end < intervals[i+1][0]) {
                result.Add(new int[2] { start, end });
                start = int.MaxValue;
                end = 0;
            }
        }
        return result.ToArray();
    }
}