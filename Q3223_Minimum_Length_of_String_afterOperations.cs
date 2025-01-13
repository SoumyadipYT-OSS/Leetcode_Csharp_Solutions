public class Solution {
    public int MinimumLength(string s) {
        var freqMap = new Dictionary<char, int>();
        
        // Step 1: Count frequency of each character in the string
        foreach (var c in s) {
            if (freqMap.ContainsKey(c)) {
                freqMap[c]++;
            } else {
                freqMap[c] = 1;
            }
        }

        int deletions = 0;

        // Step 2: Calculate deletions based on frequency of each character
        foreach (var count in freqMap.Values) {
            if (count > 2) {
                if (count % 2 == 0) {
                    deletions += (count - 2);
                } else {
                    deletions += (count - 1);
                }
            }
        }

        // Step 3: Return the final length of the string after deletions
        return s.Length - deletions;
    }
}
