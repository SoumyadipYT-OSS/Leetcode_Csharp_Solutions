public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        int index = 0;
        List<string> result = new();

        for (int i = 1; i <= n; i++)
        {
            result.Add("Push");

            if (target[index] == i)
            {   
                index++;
            }
            else
            {   
                result.Add("Pop");
            }

            if (index == target.Length)
            {
                break;
            }
        }

        return result;
    }
}
