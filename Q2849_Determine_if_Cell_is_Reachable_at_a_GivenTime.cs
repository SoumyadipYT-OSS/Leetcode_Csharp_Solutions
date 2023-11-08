public class Solution {
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t) {
        if (sx == fx && sy == fy && t == 1)
            {
                return false;
            }

            int deltaX = Math.Abs(fx - sx);
            int deltaY = Math.Abs(fy - sy);
            return Math.Min(deltaX, deltaY) + Math.Abs(deltaX - deltaY) <= t;
    }
}