public class Solution {
    public string DecodeAtIndex(string s, int k) {
        long size = 0;
        int n = s.Length;

        for (int i = 0; i < n; i++) {
            char c = s[i];
            if (Char.IsDigit(c)) {
                size *= c - '0';
            } else {
                size++;
            }
        }

        for (int i = n - 1; i >= 0; i--) {
            char c = s[i];
            k = (int) (k % size);
            if (k == 0 && Char.IsLetter(c)) {
                return Char.ToString(c);
            }
            if (Char.IsDigit(c)) {
                size /= c - '0';
            } else {
                size--;
            }
        }

        throw null;
    }
}
