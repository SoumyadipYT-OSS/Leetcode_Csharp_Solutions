public class Solution {
    public int CountHomogenous(string s) {
        int count = 0;
        int mod = 1000000007;
        int consecutive = 1;

        for (int i = 1; i <= s.Length; i++) {
            if (i < s.Length && s[i] == s[i - 1]) {
                consecutive++;
            } else {
                count = (int)((count + (long)consecutive * (consecutive + 1) / 2) % mod);
                consecutive = 1;
            }
        }

        return count;
    }
}