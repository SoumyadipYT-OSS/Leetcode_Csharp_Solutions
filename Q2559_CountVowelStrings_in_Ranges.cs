public class Solution {
    private bool IsVowel(char c) {
        return "aeiou".IndexOf(c) >= 0;
    }

    private bool StartsAndEndsWithVowel(string word) {
        return IsVowel(word[0]) && IsVowel(word[word.Length - 1]);
    }

    public int[] VowelStrings(string[] words, int[][] queries) {
        int n = words.Length;
        int[] prefixSum = new int[n+1];

        for (int i=0; i<n; i++) {
            prefixSum[i+1] = prefixSum[i] + (StartsAndEndsWithVowel(words[i]) ? 1 : 0);
        }

        int[] res = new int[queries.Length];
        for (int i=0; i<queries.Length; i++) {
            int li = queries[i][0];
            int ri = queries[i][1];
            res[i] = prefixSum[ri + 1] - prefixSum[li];
        }

        return res;
    }
}
