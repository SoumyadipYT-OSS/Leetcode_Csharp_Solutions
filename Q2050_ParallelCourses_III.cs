public class Solution {
    public int MinimumTime(int n, int[][] relations, int[] time) {
        var action = _MinimumTime;
        return action(n, relations, time);
    }

private int _MinimumTime(int n, int[][] relations, int[] time)
{
    List<int>[] adjList = new List<int>[n + 1];
    for (int node = 1; node <= n; node++)
        adjList[node] = new();
    int[] countInputs = new int[n + 1];
    foreach (var relation in relations)
    {
        adjList[relation[0]].Add(relation[1]);
        countInputs[relation[1]]++;
    }
    Stack<int> visitings = new();
    for (int node = 1; node <= n; node++)
        if (countInputs[node] == 0)
            visitings.Push(node);
    int max = 0;
    int[] preMaxTimes = new int[n + 1];
    
    while (visitings.Count > 0)
    {
        var node = visitings.Pop();
        var curTime = preMaxTimes[node] + time[node - 1];
        var nexts = adjList[node];
        if (nexts.Count == 0)
        {
            max = Math.Max(max, curTime);
            continue;
        }
        foreach (var next in nexts)
        {
            preMaxTimes[next] = Math.Max(preMaxTimes[next], curTime);
            countInputs[next]--;
            if (countInputs[next] == 0)
                visitings.Push(next);
        }
    }
    return max;
    }
}
