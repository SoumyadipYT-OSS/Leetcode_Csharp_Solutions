public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        int n = s.Length;
            int[] dp = new int[n+1];
            for (int i = 1; i <= n; i++)
            {
                dp[i] = dp[i - 1] + 1;
                foreach (var word in dictionary)
                {
                    if (i >= word.Length && s.Substring(i - word.Length, word.Length).Equals(word))
                    {
                        dp[i] = Math.Min(dp[i], dp[i - word.Length]);
                    }
                }
            }
            return dp[n];
    }
}