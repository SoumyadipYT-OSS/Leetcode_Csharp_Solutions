public class Solution 
{
    public string RemoveDuplicateLetters(string s) 
    {
        int[] counts = new int[26];
       
        for (int i = 0; i < s.Length; i++) 
            counts[s[i] - 'a']++;
        
        int index = 0;
        for (int i = 0; i < s.Length; i++) 
        {
            counts[s[i] - 'a']--;

            if (s[i] < s[index]) 
                index = i;
            if (counts[s[i] - 'a'] == 0) 
                break;
        }
        
        if(s.Length == 0) return string.Empty;

        string rest = s.Substring(index + 1);
        rest = rest.Replace(s[index].ToString(), string.Empty);

        return s[index] + RemoveDuplicateLetters(rest);
    }
}