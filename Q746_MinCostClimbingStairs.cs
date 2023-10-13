public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        if(cost.Length == 1)
            return 0;

        int[] steps = new int[cost.Length];

        steps[cost.Length - 1] = cost[cost.Length - 1];
        steps[cost.Length - 2] = cost[cost.Length - 2];

        for(int i = cost.Length - 3; i >= 0; i--)
        {
            steps[i] = cost[i] + Math.Min(steps[i + 1], steps[i + 2]);
        }

        return Math.Min(steps[0], steps[1]);
    }
} 