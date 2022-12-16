public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length ) return string.Empty;

        Dictionary<char, int> map = new();
        Dictionary<char, int> currMap = new();
        InitializeMap(map, currMap, t);
        int have = 0;
        int need = map.Keys.Count();
        bool flag = false;

        int left = 0;
        int right = 0;
        int aleft = 0;
        int aright = 0;
        int min = s.Length;
        while (right < s.Length) {
            if (currMap.ContainsKey(s[right])) {
                currMap[s[right]]++;
                if (currMap[s[right]] == map[s[right]]) {
                    have++;
                }
            }
            while (have == need) {
                flag = true;
                int len = right - left + 1;
                if (len <= min) {
                    min = len;
                    aleft = left;
                    aright = right;
                }
                if (currMap.ContainsKey(s[left])) {
                    currMap[s[left]]--;
                    if (currMap[s[left]] < map[s[left]]) {
                        have--;
                    }
                }
                left++;
            }
            right++;
        }
        string ans = "";
        if (flag) {
            for (int i = aleft; i <= aright; i++) {
                ans += s[i];
            }
        }
        return ans;
    }

    public static void InitializeMap(Dictionary<char, int> map, Dictionary<char, int> currMap, string t) {
        for (int i = 0; i < t.Length; i++) {
            if (!map.ContainsKey(t[i])) {
                map[t[i]] = 0;
            }
            map[t[i]]++;
            currMap[t[i]] = 0;
        }
    }
}