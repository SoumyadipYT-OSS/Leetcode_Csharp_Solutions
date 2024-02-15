public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target) {
                Dictionary<int, List<int>> routeDictionary = new Dictionary<int, List<int>>();
        Queue<(int stop, int length)> queue = new Queue<(int stop, int length)>();
        queue.Enqueue((source, 0));


        for (int i = 0; i < routes.Length; i++)
        {
            for (int j = 0; j < routes[i].Length; j++)
            {
                if (!routeDictionary.ContainsKey(routes[i][j]))
                {
                    routeDictionary.Add(routes[i][j], new List<int>());
                }

                //I can take which buses to a stop
                routeDictionary[routes[i][j]].Add(i);
            }
        }

        HashSet<int> visitedBuses = new HashSet<int>();
        HashSet<int> visitedStops = new HashSet<int>();

        while (queue.Any())
        {
            var item = queue.Dequeue();
            if (item.stop == target)
                return item.length;

            foreach (var bus in routeDictionary[item.stop])
            {
                if (visitedBuses.Contains(bus)) continue;
                visitedBuses.Add(bus);


                for (int i = 0; i < routes[bus].Length; i++)
                {
                    if (visitedStops.Contains(routes[bus][i])) continue;
                    visitedStops.Add(routes[bus][i]);
                    queue.Enqueue((routes[bus][i], item.length + 1));
                }
            }

        }
        return -1;
    }
}