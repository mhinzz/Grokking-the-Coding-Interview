public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) {
            return false;
        }

        int[] s1Hash = new int[26]; 
        int[] s2Hash = new int[26];

        for(int i=0; i<s1.Length; i++) {
            s1Hash[s1[i] - 97] ++;
            s2Hash[s2[i] - 97] ++;
        }

        if(s1Hash.SequenceEqual(s2Hash)) {
            return true; 
        }
        
        for(int i=s1.Length; i<s2.Length; i++) {   
            s2Hash[s2[i] - 97] ++;
            s2Hash[s2[i - s1.Length] - 97]--;

            if(s1Hash.SequenceEqual(s2Hash)) {
                return true; 
            }
        }
        return false;
    }
}