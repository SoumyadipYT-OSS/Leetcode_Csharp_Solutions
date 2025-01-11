using System.Numerics;

public class Solution {
    public bool CanConstruct(string s, int k) {
        if (s.Length < k)
            return false;
        if (s.Length == k)
            return true;

        int odd = 0;

        foreach (char chr in s)
            odd ^= (1 << (chr - 'a'));

        return BitOperations.PopCount((uint)odd) <= k;
    }
}
