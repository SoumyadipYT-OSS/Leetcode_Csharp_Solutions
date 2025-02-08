/* Find the Number of Distinct Colors Among the Balls */

public class Solution {
    public int[] QueryResults(int limit, int[][] queries) {
        // Time Complexity: O(N), where N is the length of queries
        // Space Complexity: O(N)
        Dictionary<int, int> ballCount = new Dictionary<int, int>();
        Dictionary<int, int> colorCount = new Dictionary<int, int>();
        int[] result = new int[queries.Length];
        int i = 0;

        foreach (var query in queries) {
            int ball = query[0], color = query[1];
            if (ballCount.ContainsKey(ball)) {
                int prevColor = ballCount[ball];
                if (--colorCount[prevColor] == 0) {
                    colorCount.Remove(prevColor);
                }
            }
            ballCount[ball] = color;
            if (!colorCount.ContainsKey(color)) {
                colorCount[color] = 0;
            }
            colorCount[color]++;
            result[i++] = colorCount.Count;
        }
        return result;
    }
}
