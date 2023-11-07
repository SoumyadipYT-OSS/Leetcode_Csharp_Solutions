public class Solution
{
    private const int MaxArrivalTime = 100_000;

    public int EliminateMaximum(int[] distances, int[] speeds)
    {
        var monsterCountsByArrivalTime = new int[MaxArrivalTime + 1];
        for (int i = 0; i < distances.Length; i++)
        {
            int arrivalTime = Math.DivRem(distances[i], speeds[i], out int remainder);
            if (remainder > 0)
                arrivalTime++;
            monsterCountsByArrivalTime[arrivalTime]++;
        }

        int arrivedMonsterCount = 0;
        for (int currentTime = 1; currentTime <= MaxArrivalTime; currentTime++)
        {
            arrivedMonsterCount += monsterCountsByArrivalTime[currentTime];
            int killCount = currentTime;
            if (killCount < arrivedMonsterCount)
                return killCount;
        }
        return arrivedMonsterCount;
    }
}