public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int len = letters.Length;
        for(int i=0;i<len;i++){
            if(letters[i]>target)
                return letters[i];
        }
        return letters[0];
    }
}