public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        IList<int> ans = new List<int>();

        int[] selectString = new int[26];
        foreach (var item in p) {
            selectString[item - 'a']++;
        }

        int start = 0;
        int[] searchedString = new int[26];
        for (int end = 0; end < s.Length; end++) {
            searchedString[s[end] - 'a']++;
            if (end - start + 1 < p.Length) {
                continue;
            }
            if (selectString.SequenceEqual(searchedString)) {
                ans.Add(start);
            }
            if (end - start + 1 > p.Length)	{
                searchedString[s[start] - 'a']--;
                start++;
                searchedString[s[end] - 'a']--;
                end--;
            }
        }

        return ans;
    }
}