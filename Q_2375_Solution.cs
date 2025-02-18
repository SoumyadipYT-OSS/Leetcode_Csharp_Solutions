/* Construct Smallest Number From DI String */

public class Solution {
    public string SmallestNumber(string pattern) {
        var n = pattern.Length;
        var sequence = new char[n + 1];
        var previousIndex = 0;
        for (var i = 0; i <= n; i++)
        {
            sequence[i] = (char)(i + '1');
            if (i == n || pattern[i] == 'I')
            {
                Array.Reverse(sequence, previousIndex, i - previousIndex + 1);
                previousIndex = i + 1;
            }
        }

        return new string(sequence);
    }
}
