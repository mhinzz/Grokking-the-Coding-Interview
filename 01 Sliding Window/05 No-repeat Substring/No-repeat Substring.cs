public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var maxlen = 0;
        var lastIndexByChar = Enumerable.Repeat(-1, 128).ToArray();
        
        for (int i = 0, start = -1; i < s.Length; i++) {
            var c = (int)s[i];
            start = Math.Max(start, lastIndexByChar[c]);
            maxlen = Math.Max(maxlen, i - start);            
            lastIndexByChar[c] = i;
        }
        return maxlen;
    }
}