public class Graph
{
    private int n;
    private Dictionary<int, List<int[]>> adjacencyList;

    public Graph(int n, int[][] edges)
    {
        this.n = n;
        this.adjacencyList = new Dictionary<int, List<int[]>>();

        foreach (var edge in edges)
        {
            int from = edge[0];
            int to = edge[1];
            int cost = edge[2];

            if (!adjacencyList.ContainsKey(from))
            {
                adjacencyList[from] = new List<int[]>();
            }

            adjacencyList[from].Add(new int[] { to, cost });
        }
    }

    public void AddEdge(int[] edge)
    {
        int from = edge[0];
        int to = edge[1];
        int cost = edge[2];

        if (!adjacencyList.ContainsKey(from))
        {
            adjacencyList[from] = new List<int[]>();
        }

        adjacencyList[from].Add(new int[] { to, cost });
    }

    public int ShortestPath(int node1, int node2)
    {
        int[] distance = new int[n];
        bool[] visited = new bool[n];

        // Initialize distances to infinity and mark all nodes as unvisited
        for (int i = 0; i < n; i++)
        {
            distance[i] = int.MaxValue;
            visited[i] = false;
        }

        // Distance from source to itself is 0
        distance[node1] = 0;

        // Find shortest path for all nodes
        for (int count = 0; count < n - 1; count++)
        {
            int u = MinDistance(distance, visited);
            visited[u] = true;

            if (adjacencyList.ContainsKey(u))
            {
                foreach (var neighbor in adjacencyList[u])
                {
                    int v = neighbor[0];
                    int edgeCost = neighbor[1];

                    if (!visited[v] && distance[u] != int.MaxValue && distance[u] + edgeCost < distance[v])
                    {
                        distance[v] = distance[u] + edgeCost;
                    }
                }
            }
        }

        return distance[node2] == int.MaxValue ? -1 : distance[node2];
    }

    private int MinDistance(int[] distance, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < n; v++)
        {
            if (!visited[v] && distance[v] <= min)
            {
                min = distance[v];
                minIndex = v;
            }
        }

        return minIndex;
    }
}