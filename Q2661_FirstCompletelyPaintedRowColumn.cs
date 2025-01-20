public class Solution {
    public int FirstCompleteIndex(int[] arr, int[][] mat) {
        int i = 0;
        int m = mat.Length;
        int n = mat[0].Length;
        (int col, int row)[] pos = new (int col, int row)[m * n];
        int[] cols = new int[n];
        int[] rows = new int[m];
        for (int j = 0; j < m; j++) {
            for (int k = 0; k < n; k++) {
                int value = mat[j][k];
                if (value == arr[i]) {
                    if (this.IncrementCounts(cols, rows, k, j)) {
                        return i;
                    }
                    i++;
                } else {
                    pos[value - 1] = (k, j);
                }
            }
        }
        while (i < arr.Length) {
            (int col, int row) cell = pos[arr[i] - 1];
            if (this.IncrementCounts(cols, rows, cell.col, cell.row)) {
                break;
            }
            i++;
        }
        return i;
    }

    private bool IncrementCounts(int[] cols, int[] rows, int col, int row) {
        cols[col]++;
        rows[row]++;
        return cols[col] == rows.Length || rows[row] == cols.Length;
    }
}
