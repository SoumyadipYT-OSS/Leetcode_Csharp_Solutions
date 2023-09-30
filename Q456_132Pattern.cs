public class Solution
{
    public bool Find132pattern(int[] nums)
    {
        var s = new Stack<int>();

        var max2 = int.MinValue;

        for(var i=nums.Length-1; i>=0; i--)
        {
            if(nums[i] < max2)
                return true;

            while(s.Count > 0 && nums[i] > s.Peek())
                max2 = s.Pop();

            if(s.Count == 0 || s.Peek() != nums[i])
                s.Push(nums[i]);
        }
        

        return false;
    }
}