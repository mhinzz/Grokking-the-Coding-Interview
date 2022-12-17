public class Solution {
    public string FrequencySort(string s) {
        int[] cnts = new int[256];
        foreach (char c in s) cnts[c]++;
        
        string[] chars = new string[s.Length + 1];
        for (int i = 0; i < 256; i++) {
            if (cnts[i] > 0) {
                int cnt = cnts[i];
                if (chars[cnt] == null) chars[cnt] = "";
                chars[cnt] += (char)i;
            }
        }
        
        StringBuilder output = new StringBuilder();
        for (int i = chars.Length - 1; i >= 0; i--) {
            AppendEachXTimes(output, chars[i], i);
        }
        
        return output.ToString();
    }
    
    public void AppendEachXTimes(StringBuilder builder, string s, int times) {
        if (s == null) return;
        foreach (char c in s) {
            for (int i = 0; i < times; i++) builder.Append(c);
        }
    }
}