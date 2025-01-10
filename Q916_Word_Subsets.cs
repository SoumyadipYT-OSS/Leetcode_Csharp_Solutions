public class Solution {
    public IList<string> WordSubsets(IList<string> words1, IList<string> words2) {
        int[] freq = new int[26];
        foreach (var word in words2) {
            int[] count = new int[26];
            foreach (char c in word)
                count[c - 'a']++;
            for (int i = 0; i < 26; i++)
                freq[i] = Math.Max(freq[i], count[i]);
        }

        List<string> res = new List<string>();
        foreach (var word in words1) {
            int[] count = new int[26];
            foreach (char c in word)
                count[c - 'a']++;
            bool isUniversal = true;
            for (int i = 0; i < 26; i++) {
                if (count[i] < freq[i]) {
                    isUniversal = false;
                    break;
                }
            }
            if (isUniversal) {
                res.Add(word);
            }
        }

        return res;
    }
}
