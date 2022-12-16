public class Solution {
    public bool BackspaceCompare(string S, string T) {
        int si = S.Length-1;
        int ti = T.Length-1;
        
        while (si >=0 || ti >= 0) {
            si = GetNextCharIndex(S, si);
            ti = GetNextCharIndex(T, ti);
            
            if (si < 0 && ti < 0) {
                return true;
            }
            if ((si >=0 && ti < 0) || (ti >=0 && si < 0)) {
                return false;
            }
            if (S[si] != T[ti]) {
                return false;
            }
            si--;
            ti--;
        }
        return true;
    }

    private int GetNextCharIndex(string s, int index) {
        int b = 0;
        while (index >= 0 && (s[index] == '#' || b > 0)) {
            b = (s[index] == '#') ? b + 1 : b - 1;
            index--;
        }
        return index;
    }
}