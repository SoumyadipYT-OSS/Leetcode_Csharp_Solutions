/* Check if One String Swap Can Make Strings Equal */

public class Solution {
    public bool AreAlmostEqual(string s1, string s2) 
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        int matches = 0;
        char s1Char = ' ';
        char s2Char = ' ';
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] == s2[i])
            {
                matches++;
            }
            else if (s1Char != ' ')
            {
                if (!(s1Char == s2[i] && s2Char == s1[i]))
                {
                    return false;
                }
            }
            else
            {
                s1Char = s1[i];
                s2Char = s2[i];
            }
        }

        return matches == s1.Length || matches == s1.Length - 2;
    }
}
