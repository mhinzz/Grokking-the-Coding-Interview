public class Solution {
    public int LeastInterval (char[] tasks, int n) {
        if (n == 0) return tasks.Length;
        
        int[] counts = new int[26];
        foreach (char c in tasks) counts[c-'A']++;
        
        int maxFreq = counts.Max();
        
        return Math.Max (
            tasks.Length, 
            (maxFreq - 1) * (n + 1) + counts.Count(c => c == maxFreq)
        );
    }
}