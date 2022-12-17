public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> result = new List<int>();
        
        if (nums == null || nums.Length == 0)
            return result.ToArray();
        
        Dictionary<int,int> freq = new Dictionary<int,int>();
        foreach (int i in nums) {
            if (freq.ContainsKey(i))
                freq[i]++;
            else
                freq[i] = 1;            
        }
        
        Dictionary<int,List<int>> dict = new Dictionary<int,List<int>>();
        foreach (var kv in freq) {
            if (dict.ContainsKey(kv.Value))
                dict[kv.Value].Add(kv.Key);
            else
                dict[kv.Value] = new List<int>() { kv.Key };
        }
        
        int[] arrFreq = new int[dict.Count];
        dict.Keys.CopyTo(arrFreq, 0);
        Array.Sort(arrFreq);

        for (int i = arrFreq.Length-1; i >= 0; i--) {
             foreach(int num in dict[arrFreq[i]]) {
                result.Add(num);
                if (result.Count == k)
                    return result.ToArray();
            }           
        }
        return result.ToArray();
    }
}