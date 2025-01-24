public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) { 
        var saveNodes = new List<int>();
        int[] stage = new int[graph.Length];

        bool DFS(int cur){
            if(stage[cur] != 0) return stage[cur] == 2;

            stage[cur] = 1;
            foreach(var neighbor in graph[cur]){
                if(!DFS(neighbor)) return false;
            }
            stage[cur] = 2;
            return true;
        }

        for( int i = 0; i < graph.Length; i++){
            if(DFS(i)) saveNodes.Add(i);
        }
        return saveNodes;
    }
}
