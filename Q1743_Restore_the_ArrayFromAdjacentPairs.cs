public class Solution {
    public int[] RestoreArray(int[][] adjacentPairs) {
        Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

        foreach (var pair in adjacentPairs) {
            if (!adjList.ContainsKey(pair[0])) {
                adjList[pair[0]] = new List<int>();
            }
            if (!adjList.ContainsKey(pair[1])) {
                adjList[pair[1]] = new List<int>();
            }
            adjList[pair[0]].Add(pair[1]);
            adjList[pair[1]].Add(pair[0]);
        }

        int start = 0;
        foreach (var pair in adjList) {
            if (pair.Value.Count == 1) {
                start = pair.Key;
                break;
            }
        }

        int n = adjacentPairs.Length + 1;
        int[] result = new int[n];
        result[0] = start;
        result[1] = adjList[start][0];

        for (int i = 2; i < n; i++) {
            var list = adjList[result[i - 1]];
            result[i] = result[i - 2] == list[0] ? list[1] : list[0];
        }

        return result;
    }
}