/* Clear Digits */

using System;
using System.Text;

public class Solution 
{
    public string ClearDigits(string s) 
    {
        StringBuilder sb = new StringBuilder(s);

        for (int i = 0; i < sb.Length; i++) 
        {
            if (char.IsDigit(sb[i])) 
            {
                if (i > 0) 
                {
                    sb.Remove(i - 1, 1);
                    i--;
                }
                sb.Remove(i, 1);
                i--;
            }
        }

        return sb.ToString();
    }
}
