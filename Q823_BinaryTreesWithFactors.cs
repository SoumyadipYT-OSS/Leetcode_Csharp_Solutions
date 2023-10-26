public class Solution {
    private const int MOD = 1000000007;

    public int NumFactoredBinaryTrees(int[] arr) {
        Array.Sort(arr);
        HashSet<int> s = new HashSet<int>(arr);
        Dictionary<int, long> dp = new Dictionary<int, long>();
        foreach (int x in arr) dp[x] = 1;
        
        foreach (int i in arr) {
            foreach (int j in arr) {
                if (j > Math.Sqrt(i)) break;
                if (i % j == 0 && s.Contains(i / j)) {
                    long temp = dp[j] * dp[i / j];
                    dp[i] = (dp[i] + (i / j == j ? temp : temp * 2)) % MOD;
                }
            }
        }
        
        long result = 0;
        foreach (long val in dp.Values) {
            result = (result + val) % MOD;
        }
        return (int)result;
    }
}