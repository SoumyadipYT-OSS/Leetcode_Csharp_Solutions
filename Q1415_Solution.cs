/* The k-th Lexicographical String of All Happy Strings of Length n */

public class Solution {
    public string GetHappyString(int n, int k)
    {
        var total = 3 * (1 << (n - 1));

        if (k > total)
        {
            return string.Empty;
        }

        var stringBuilder = new StringBuilder();

        var current = 0;
        for (int i = 0; i < 3; i++)
        {
            if (current + (1 << (n - 1)) >= k)
            {
                stringBuilder.Append((char)('a' + i));
                break;
            }
            current += 1 << (n - 1);
        }

        for (int i = 1; i < n; i++)
        {
            if (current + (1 << (n - i - 1)) >= k)
            {
                stringBuilder.Append(stringBuilder[^1] == 'a' ? 'b' : 'a');
            }
            else
            {
                stringBuilder.Append(stringBuilder[^1] == 'c' ? 'b' : 'c');
                current += 1 << (n - i - 1);
            }
        }

        return stringBuilder.ToString();
    }
}
