public class Solution {
    public int BitwiseComplement(int n) {
        return (int)Math.Pow(2, Convert.ToString(n, 2).Length)-n-1;
    }
}