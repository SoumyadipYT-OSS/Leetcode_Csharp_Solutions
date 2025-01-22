public class Solution {
    public int[][] HighestPeak(int[][] isWater) {
        int m = isWater.Length;
        int n = isWater[0].Length;
        int[][] maxHeight = InitializeResultMatrix(m,n);
        Queue<(int x, int y)> bfsQueue = new Queue<(int x, int y)>();

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(isWater[i][j] == 1)
                    bfsQueue.Enqueue((i,j));
                else
                    maxHeight[i][j] = -1;
            }
        }

        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};

        while(bfsQueue.Count > 0){
            int nn = bfsQueue.Count;
            for(int i = 0; i < nn; i++){
                var currNode = bfsQueue.Dequeue();

                for(int d = 0; d < 4; d++){
                    int x = currNode.x + dx[d];
                    int y = currNode.y + dy[d];

                    if(x < 0 || y < 0 || x >= m || y >= n || maxHeight[x][y] != -1)
                        continue;

                    maxHeight[x][y] = maxHeight[currNode.x][currNode.y] + 1;
                    bfsQueue.Enqueue((x,y));
                }
            }
        }
        return maxHeight;
    }

    private int[][] InitializeResultMatrix(int m, int n){
        int[][] result = new int[m][];
        for(int i = 0; i < m; i++)
            result[i] = new int[n];

        return result;
    }
}
