public class Solution {
    public int PaintWalls(int[] cost, int[] time) {
        int n = cost.Length;
        int [] dp = new int[n + 1];
        Array.Fill(dp, (int)1e9);
        dp[0] = 0;
        for (int i = 0; i < n; ++i)
            for (int j = n; j > 0; --j)
                dp[j] = Math.Min(dp[j], dp[Math.Max(j - time[i] - 1, 0)] + cost[i]);
        return dp[n];
    }
}