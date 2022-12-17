public class Solution {
    public int NumTrees(int n) {
        if (n == 1) return 1;
        if (n == 2) return 2;
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 2;
        for (int i = 3; i <= n; i++) {
            int res = 0;
            for (int j = 0; j < i; j++) res += dp[j] * dp[i - (j + 1)];
                dp[i] = res;
        }
        return dp[n];
    }
}