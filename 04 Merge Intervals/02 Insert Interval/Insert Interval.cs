public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int sn = newInterval[0];
        int en = newInterval[1];
        int len = intervals.Length;
        List<int[]> result = new List<int[]>();
        int i = 0;
        
        while (i < len) {
            int[] iv = intervals[i];
            int s = iv[0];
            int e = iv[1];
            if (e < sn) {
                result.Add(iv);
            }
            else if (en < s) {
                result.Add(new int[2] { sn, en });
                break;
            }
            else {
                sn = Math.Min(s, sn);
                en = Math.Max(e, en);
            }
            i++;
        }
        
        if (i == len) {
            result.Add(new int[2] { sn, en });
        }
        else {
            while (i < len) {
                result.Add(intervals[i]);
                i++;
            } 
        }
        return result.ToArray();
    }
}