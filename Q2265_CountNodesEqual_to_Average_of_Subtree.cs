public class Solution {
    int res = 0;
    public (int, int) PostOrder(TreeNode root)
    {
        if(root == null)
            return (0,0);
        (int Key, int Val) left = PostOrder(root.left);
        (int Key, int Val) right = PostOrder(root.right);

        int nodeSum = left.Key + right.Key + root.val;
        int nodeCount = left.Val + right.Val + 1;

        if(root.val == nodeSum / (nodeCount))
            res++;
        return (nodeSum, nodeCount);
    }
    public int AverageOfSubtree(TreeNode root) {
        PostOrder(root);
        return res;
    }
}