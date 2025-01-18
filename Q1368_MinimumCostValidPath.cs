/*
  1368. Minimum Cost to Make at Least One Valid Path in a Grid
*/

public class Solution {
    public int MinCost(int[][] grid) {
        var m = grid.Length;
        var n = grid[0].Length;
        var cost = new int[m, n];
        var queue = new PriorityQueue<(int,int,int), int>();//row, col, cost
        var diffs = new int[,] {{0, 1}, {0, -1}, {1, 0}, {-1, 0}};

        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                cost[i, j] = Int32.MaxValue;
            }
        }

        queue.Enqueue((0, 0, 0), 0);
        cost[0,0] = 0;

        while(queue.Count > 0)
        {
            var cur = queue.Dequeue();

            if (cur.Item1 == m -1 && cur.Item2 == n -1)
            {
                return cur.Item3;
            }

            for(int i=1;i<=4;i++)
            {
                var nextCost = cur.Item3;
                if (grid[cur.Item1][cur.Item2] != i)
                {
                    nextCost++;
                }
                var nr = cur.Item1 + diffs[i-1, 0];
                var nc = cur.Item2 + diffs[i-1, 1];

                if (nr < 0 || nr >= m || nc < 0 || nc >= n)
                {
                    continue;
                }

                if(cost[nr, nc] > nextCost)
                {
                    cost[nr, nc] = nextCost;
                    queue.Enqueue((nr, nc, nextCost), nextCost);
                }
            }
        }

        return -1;
    }
}
