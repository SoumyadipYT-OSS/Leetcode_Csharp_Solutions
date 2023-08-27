public class Solution
{
    public IList<IList<int>> CombinationSum(int[] cand, int goal)
    {
        var res = new List<IList<int>> ();
        if (goal == 1)
        {
            return res;
        }
        Array.Sort(cand);
        Dfs(cand, goal, 0, new Stack<int>(), res);
        return res;
    }

    private static void Dfs(int[] cand, int goal, int start, Stack<int> temp, List<IList<int>> res)
    {
        if (goal == 0)
        {
            res.Add(new List<int>(temp));
            return;
        }

        if (start >= cand.Length || cand[start] > goal)
        {
            return;
        }

        Dfs(cand, goal, start + 1, temp, res);

        temp.Push(cand[start]);
        Dfs(cand, goal - cand[start], start, temp, res);
        temp.Pop();
    }
}