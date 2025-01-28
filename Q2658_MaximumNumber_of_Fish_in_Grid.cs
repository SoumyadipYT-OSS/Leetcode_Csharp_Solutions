public class Solution {
    public int FindMaxFish(int[][] grid) {
        int maxFish = 0;

        int m = grid.Length;
        int n = grid[0].Length;

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] != 0) {
                    int fishStartingHere = GetTotalFish(grid, i, j, m, n);
                    maxFish = Math.Max(maxFish, fishStartingHere);
                }
            }
        }

        return maxFish;
    }

    int GetTotalFish(int[][] grid, int i, int j, int m, int n) {
        if (i < 0 || j < 0 || i >= m || j >= n || grid[i][j] == 0) {
            return 0;
        }


        int totalFish = grid[i][j];

        grid[i][j]=0;

        totalFish+=
            GetTotalFish(grid, i + 1, j, m, n)
            + GetTotalFish(grid,  i - 1, j, m, n)
            + GetTotalFish(grid, i, j + 1, m, n)
            + GetTotalFish(grid, i, j - 1, m, n);

        return totalFish;
    }
}
