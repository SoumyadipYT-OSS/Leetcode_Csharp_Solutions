public class Solution {
    public int MaximumInvitations(int[] favorite) 
    {
        int n = favorite.Length;
        int[] indegree = new int[n];
        for (int i = 0; i < n; i++) 
            indegree[favorite[i]]++;

        var queue = new Queue<int>();
        for (int i = 0; i < n; i++) 
            if (indegree[i] == 0) 
                queue.Enqueue(i);

        int[] longestPath = new int[n];
        while (queue.Count > 0) 
        {
            int curr = queue.Dequeue();
            int next = favorite[curr];
            longestPath[next] = Math.Max(longestPath[next], longestPath[curr] + 1);
            if (--indegree[next] == 0) 
                queue.Enqueue(next);
        }

        int maxCircle = 0, maxPairChains = 0;
        bool[] visited = new bool[n];
        for (int i = 0; i < n; i++) 
        {
            if (!visited[i]) 
            {
                int curr = i;
                var seen = new HashSet<int>();
                while (!seen.Contains(curr) && !visited[curr]) 
                {
                    seen.Add(curr);
                    visited[curr] = true;
                    curr = favorite[curr];
                }
                if (seen.Contains(curr)) 
                {
                    int cycleLength = 0;
                    int start = curr;
                    while (true) 
                    {
                        cycleLength++;
                        curr = favorite[curr];
                        if (curr == start) break;
                    }

                    if (cycleLength == 2) 
                    {
                        int a = favorite[start], b = start;
                        maxPairChains += longestPath[a] + longestPath[b] + 2;
                    } 
                    else 
                    {
                        maxCircle = Math.Max(maxCircle, cycleLength);
                    }
                }
            }
        }

        return Math.Max(maxCircle, maxPairChains);
    }
}
