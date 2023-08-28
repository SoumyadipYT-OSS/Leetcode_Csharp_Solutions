public class Solution {
    public IList<IList<string>> Partition(string s) {
        List<IList<string>> partitions = new();
        List<string> currentPartition = new();
        
        Backtrack(0);
        
        return partitions;
        
        void Backtrack(int i)
        {
            if (i == s.Length)
            {
                partitions.Add(new List<string>(currentPartition));
                return;
            }
            
            for (int j = i; j < s.Length; j++)
            {
                if (i == j || IsPalindrome(i, j))
                {
                    currentPartition.Add(s.Substring(i, j - i + 1));
                    Backtrack(j + 1);
                    currentPartition.RemoveAt(currentPartition.Count - 1);
                }
            }
            
            bool IsPalindrome(int l, int r)
            {
                while (l < r)
                {
                    if (s[l++] != s[r--])
                    {
                        return false;
                    }
                }
                
                return true;
            }
        }
    }
}