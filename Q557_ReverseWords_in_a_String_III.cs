public class Solution {
    public string ReverseWords(string s) {
        
        //conver to list of string; split by space
        //two pointer on each word to reverse
        //stringbuilder; append each reverse word
        //before next word; add space

        string[] words = s.Split(new char[]{ ' '});

        StringBuilder sb = new StringBuilder();

        for(int i=0; i<words.Length; i++)
        {
            StringBuilder word = new StringBuilder(words[i]);

            int left = 0;
            int right= word.Length-1;

            while(left < right)
            {
                char c = word[left];
                word[left] = word[right];
                word[right]= c;

                left++;
                right--;
            }

            if(sb.Length > 0)
            {
                sb.Append(" ");
            }
            sb.Append(word);
        }

        return sb.ToString();
    }
}