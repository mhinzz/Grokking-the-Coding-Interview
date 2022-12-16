public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> map = new();
        int left = 0;
        int right = 0;
        int max = 0;

        int maxFreqCharsCount = 0;
        while(right < s.Length) {
            if(!map.ContainsKey(s[right])) {
                map[s[right]] = 0;
            }
            map[s[right]]++;
            maxFreqCharsCount = Math.Max(maxFreqCharsCount, map[s[right]]);

            if ((right-left+1) - maxFreqCharsCount <= k) {
                max = Math.Max(max, (right-left+1));
            }
            else {
                map[s[left]]--;
                left++;
            }
            right++;
        }
        return max;
    }
}