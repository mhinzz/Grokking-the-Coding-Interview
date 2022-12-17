public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        var dict = new Dictionary<int,List<int[]>>();
        foreach (var xy in points) {
            int a = Math.Abs(xy[0]);
            int b = Math.Abs(xy[1]);
            int key = a*a + b*b;
            if (!dict.ContainsKey(key))
                dict[key] = new List<int[]>();
            dict[key].Add(xy);
        }
        
        int[] keys = new int[dict.Count];
        dict.Keys.CopyTo(keys, 0);
        Array.Sort(keys);
        
        var result = new List<int[]>(K);
        for (int i = 0; i < keys.Length; i++) {
            foreach (var a in dict[keys[i]]) {
                result.Add(a);
                if (result.Count == K)
                    return result.ToArray();
            }
        }
        return result.ToArray();
    }
}