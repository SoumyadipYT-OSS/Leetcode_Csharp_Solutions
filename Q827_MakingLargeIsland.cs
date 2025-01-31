public class Solution {
    private Dictionary<int, int> islandMap;
    public int LargestIsland(int[][] grid) {
        islandMap = new Dictionary<int, int>();
        var maxSize = 0;
        var index = 2;
        for (var i = 0; i < grid.Length; i++) {
            for (var j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 1) {
                    islandMap[index] = 0;
                    dfs(grid, i, j, index);
                    maxSize = Math.Max(maxSize, islandMap[index]);
                    index++;
                }
            }
        }
        
        for (var i = 0; i < grid.Length; i++) {
            for (var j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 0) {
                    var indexSet = new HashSet<int>();
                    if (i + 1 < grid.Length && grid[i + 1][j] > 1) {
                        indexSet.Add(grid[i+1][j]);
                    }
                    if (i - 1 >= 0 && grid[i - 1][j] > 1) {
                        indexSet.Add(grid[i-1][j]);
                    }
                    if (j + 1 < grid[0].Length && grid[i][j + 1] > 1) {
                        indexSet.Add(grid[i][j+1]);
                    }
                    if (j - 1 >= 0 && grid[i][j - 1] > 1) {
                        indexSet.Add(grid[i][j-1]);
                    }

                    var areaSum = 1;
                    foreach (var ind in indexSet) {
                        areaSum += islandMap[ind];
                    }

                    maxSize = Math.Max(maxSize, areaSum);
                }
            }
        }

        return maxSize;
    }

    private void dfs(int[][] grid, int i, int j, int index) {
        if (i >= 0 && i < grid.Length && j >= 0 && j < grid[0].Length && grid[i][j] == 1) {
            grid[i][j] = index;
            islandMap[index]++;
            dfs(grid, i + 1, j, index);
            dfs(grid, i - 1, j, index);
            dfs(grid, i, j + 1, index);
            dfs(grid, i, j - 1, index);
        }
    }
}
