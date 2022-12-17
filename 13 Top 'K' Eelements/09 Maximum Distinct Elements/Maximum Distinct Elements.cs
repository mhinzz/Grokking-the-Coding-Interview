public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
        Dictionary<int, int> memo = new Dictionary<int,int>();

        for(int i=0; i < arr.Length; i++) {
            if(!memo.ContainsKey(arr[i]))
                memo.Add(arr[i], 0);

            memo[arr[i]]++;
        }
        

        var dict = memo.OrderBy(a => a.Value);

        int unique = 0;
        foreach(var kv in dict) {
            if(kv.Value <= k)
                k -= kv.Value;
            else
                unique++;
        }

        return unique;
    }
}