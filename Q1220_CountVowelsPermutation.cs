public class Solution {
    private static ulong _mod = 1000000007;
    public int CountVowelPermutation(int n) {
        ulong a = 1, e = 1, i = 1, o = 1, u = 1;

        for (int iter = 1; iter < n; iter++) {
            ulong nextA = e + i + u, nextE = a + i, nextI = e + o, nextO = i, nextU = i + o;
            a = nextA % _mod;
            e = nextE % _mod;
            i = nextI % _mod;
            o = nextO % _mod;
            u = nextU % _mod;
        }
        
        return (int)((a + e + i + o + u) % _mod);
    }
}