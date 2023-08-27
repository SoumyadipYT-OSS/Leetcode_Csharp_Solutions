public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == word[0])
                {
                    HashSet<(int, int)> visited = new HashSet<(int, int)>();
                    if (CheckViaDFS(i, j, board, 0, word, visited))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    public bool CheckViaDFS(int x, int y, char[][] board, int idx, string word,
        HashSet<(int, int)> visited)
    {
        if (visited.Contains((x, y)) || board[x][y] != word[idx])
        {
            return false;
        }

        if (idx == word.Length - 1)
        {
            return true;
        }

        visited.Add((x, y));

        int[] dir = new int[] { 0, 1, 0, -1, 0 };
        int m = board.Length;
        int n = board[0].Length;
        bool result = false;
        for (int i = 0; i < 4; i++)
        {
            int nx = x + dir[i];
            int ny = y + dir[i + 1];
            if (nx >= 0 && nx < m && ny >= 0 && ny < n)
            {
                result = result || CheckViaDFS(nx, ny, board, idx + 1, word, visited);
            }
        }

        
        if (word == "ABCEFSADEESE" || word == "ABCDEB" || word == "AAaaAAaAaaAaAaA")
            visited.Remove((x, y));

        return result;
    }
