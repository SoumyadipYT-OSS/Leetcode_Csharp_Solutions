public class Solution {
     public int[] FullBloomFlowers(int[][] flowers, int[] persons)
    {
        var changesQueue = new PriorityQueue<int, int>();

        foreach (var bloomPeriod in flowers)
        {
            changesQueue.Enqueue(1, bloomPeriod[0]);
            changesQueue.Enqueue(-1, bloomPeriod[1] + 1);
        }

        var changesHistory = new List<(int numberOfFlowersInFullBloom, int time)>();
        changesHistory.Add((0, 0));

        var inFullBloom = 0;
        while (changesQueue.TryDequeue(out var change, out var time))
        {
            inFullBloom += change;

            if (changesHistory.Count > 0 && changesHistory[^1].time == time)
            {
                changesHistory[^1] = (inFullBloom, time);
            }
            else
            {
                changesHistory.Add((inFullBloom, time));
            }
        }

        return persons.Select(GetNumberOfFlowersInFullBloomByTime).ToArray();

        int GetNumberOfFlowersInFullBloomByTime(int time)
        {
            var l = 0;
            var r = changesHistory.Count - 1;

            while (l < r)
            {
                var mid = (l + r + 1) / 2;

                if (time >= changesHistory[mid].time)
                {
                    l = mid;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return changesHistory[l].numberOfFlowersInFullBloom;
        }
    }
}