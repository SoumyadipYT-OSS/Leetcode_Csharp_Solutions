/* Construct Binary Tree from Preorder and Postorder Traversal */

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int[] pre;
    int[] post;
    public TreeNode ConstructFromPrePost(int[] pre, int[] post) {
        this.pre = pre;
        this.post = post;
        return MakeBT(0, 0, pre.Length);
    }

    public TreeNode MakeBT(int i0, int i1, int N) {
        if (N == 0) 
            return null;
        TreeNode root = new TreeNode(pre[i0]);
        
        if (N == 1) 
            return root;

        int L = 1;
        for (; L < N; ++L)
            if (post[i1 + L-1] == pre[i0 + 1])
                break;

        root.left = MakeBT(i0+1, i1, L);
        root.right = MakeBT(i0+L+1, i1+L, N-1-L);
        return root;
    }
}
