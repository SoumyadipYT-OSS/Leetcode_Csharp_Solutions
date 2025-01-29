public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;
        int[] parent = new int[n + 1];
        int[] rank = new int[n + 1];
        for (int i = 1; i <= n; i++) {
            parent[i] = i;
            rank[i] = 1;
        }

        foreach (var edge in edges) {
            int u = edge[0], v = edge[1];
            if (!Union(u, v, parent, rank)) {
                return edge;
            }
        }
        return new int[0];
    }

    private int Find(int node, int[] parent) {
        if (parent[node] != node) {
            parent[node] = Find(parent[parent[node]], parent); // Path compression
        }
        return parent[node];
    }

    private bool Union(int u, int v, int[] parent, int[] rank) {
        int rootU = Find(u, parent);
        int rootV = Find(v, parent);

        if (rootU == rootV) return false; 

        if (rank[rootU] > rank[rootV]) {
            parent[rootV] = rootU;
        } else if (rank[rootU] < rank[rootV]) {
            parent[rootU] = rootV;
        } else {
            parent[rootV] = rootU;
            rank[rootU]++;
        }
        return true;
    }
}
