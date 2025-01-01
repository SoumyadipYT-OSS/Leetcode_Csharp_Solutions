public class Solution {
    public int MaxScore(string s) {
        int totalOnes = 0;
        foreach (char c in s) {
            if (c == '1')
                totalOnes++;
        }

        int leftZeros = 0;
        int maxScore = 0;

        for (int i=0; i<s.Length - 1; i++) {
            if (s[i] == '0')
                leftZeros++;
            else
                totalOnes--;
            
            int currentScore = leftZeros + totalOnes;
            maxScore = Math.Max(maxScore, currentScore);
        }

        return maxScore;
    }
}