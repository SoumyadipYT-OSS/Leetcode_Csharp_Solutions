public class Solution {
    public int NumWays(int steps, int arrLen) {
        
        int maxLen = Math.Min(arrLen, steps + 1);
        int MOD = 1000000007;
        
        int[][] dp = new int[steps + 1][];
        for (int i = 0; i <= steps; i++) {
            dp[i] = new int[maxLen];
        }
        
        dp[0][0] = 1;
        
        for (int i = 1; i <= steps; i++) {
            for (int j = 0; j < maxLen; j++) {
                dp[i][j] = dp[i-1][j];
                if (j > 0) {
                    dp[i][j] = (dp[i][j] + dp[i-1][j-1]) % MOD;
                }
                if (j < maxLen - 1) {
                    dp[i][j] = (dp[i][j] + dp[i-1][j+1]) % MOD;
                }
            }
        }
        
        return dp[steps][0];
    }
}