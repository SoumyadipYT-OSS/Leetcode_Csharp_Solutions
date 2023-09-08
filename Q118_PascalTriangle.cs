public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> lst = new List<IList<int>>
        {
            new List<int> { 1 }
        };

        for (int i = 1; i < numRows; i++)
        {
            var newRow = new List<int>(i+1);

            newRow.Add(1);
            for (int k = 1; k < i / 2 + 1; k++)
            {
                newRow.Add((i - k + 1) * newRow[k - 1] / k);
            }

            for (int j = newRow.Count - 1 - (i + 1) % 2; j >= 0; j--)
            {
                newRow.Add(newRow[j]);
            }

            lst.Add(newRow);
        }
        
        return lst;
    }
}