public class Solution {
     public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) {
            return string.Empty;
        }

        int start = 0;
        int maxLength = 1;

        for (int i = 1; i < s.Length; i++) {
            // Check for odd-length palindromes with s[i] as the center
            int l = i - 1;
            int r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if (r - l + 1 > maxLength) {
                    start = l;
                    maxLength = r - l + 1;
                }
                l--;
                r++;
            }

            // Check for even-length palindromes with s[i-1] and s[i] as the center
            l = i - 1;
            r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if (r - l + 1 > maxLength) {
                    start = l;
                    maxLength = r - l + 1;
                }
                l--;
                r++;
            }
        }

        return s.Substring(start, maxLength);
    }
}

