public class Solution {
    public bool CanCross(int[] stones) {
        int n = stones.Length;
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < n; ++i) {
            dict.Add(stones[i], i);
        }

        var queue = new PriorityQueue<(int i, int k), int>();
        queue.Enqueue((0, 0), 0);

        var result = false;
        var steps = 2 * n * 3;

        while(queue.Count > 0 && steps-- > 0) {
            var s = queue.Dequeue();
            if (s.i == n - 1) {
                result = true;
                break;
            }
            var k = s.k;

            var pos = stones[s.i];
            for (int i = 1; i >= -1; --i) {
                if (dict.ContainsKey(pos + k + i)) {
                    var index = dict[pos + k + i];
                    queue.Enqueue((index, k + i), -index);
                }
            }
        }

        return result;
    }
}