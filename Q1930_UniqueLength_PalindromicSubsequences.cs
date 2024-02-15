public class Solution {
    public int CountPalindromicSubsequence(string s)
    {
        var dic = new Dictionary<char, int[]>();
        for (int i = 0, len = s.Length; i < len; i++)
        {
            var c = s[i];
            if (dic.TryGetValue(c, out var arr))
            {
                arr[1] = i;
            }
            else
            {
                dic.Add(c, new[] { i, 0 });
            }
        }

        int count = 0;
        HashSet<char> set = new HashSet<char>();
        foreach (KeyValuePair<char, int[]> pair in dic)
        {
            int[] arr = pair.Value;
            int st = arr[0], end = arr[1];
            if (end - st < 2) continue;
            for (int i = st + 1; i < end; i++)
            {
                if (set.Add(s[i])) count++;
            }
            set.Clear();
        }
        return count;
    }
}
