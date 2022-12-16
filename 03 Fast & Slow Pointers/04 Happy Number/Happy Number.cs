public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> hset = new HashSet<int>() { n };
        while (n != 1) {
            int nn = 0;
            while (n > 0) {
                int d = n % 10;
                nn += d*d;
                n = n / 10; 
            }
            if (!hset.Add(nn))
                return false;
            n = nn;
        }
        return true;
    }
}