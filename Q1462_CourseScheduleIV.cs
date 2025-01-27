public class Solution {
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        var graph = new Dictionary<int, List<int>>();
        for(int i=0;i<numCourses;i++)
            graph.Add(i, new List<int>());
        
        foreach(int[] edge in prerequisites)
        {
            graph[edge[0]].Add(edge[1]);
        }

        bool[][] isReachable = new bool[numCourses][];
        for(int i=0;i<numCourses;i++)
            isReachable[i] = new bool[numCourses];

        var ans = new List<bool>();
        for(int i=0; i<numCourses; i++){
            bfs(i, numCourses, graph, isReachable);
        }

        foreach(int[] q in queries)
            ans.Add(isReachable[q[0]][q[1]]);

        return ans;
    }

    public void bfs(int i, int numCourses, Dictionary<int, List<int>> graph, bool[][] isReachable){
        var q = new Queue<int>();
        bool[] visited = new bool[numCourses];
        q.Enqueue(i);
        visited[i] = true;
        while(q.Count > 0){
            int curr = q.Dequeue();
            foreach(int val in graph[curr]){
                if(visited[val] == false){
                    isReachable[i][val] = true;
                    visited[val] = true;
                    q.Enqueue(val);
                }
            }
        }
    }
}
