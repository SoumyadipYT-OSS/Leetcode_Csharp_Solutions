public class Solution {
    private int? current_val = null;
    private int current_count = 0;
    private int max_count = 0;
    private List<int> modes = new List<int>();

    public int[] FindMode(TreeNode root) {
        in_order_traversal(root);
        return modes.ToArray();
    }

    private void in_order_traversal(TreeNode node) {
        if (node == null) return;

        in_order_traversal(node.left);

        current_count = (node.val == current_val) ? current_count + 1 : 1;
        if (current_count == max_count) {
            modes.Add(node.val);
        } else if (current_count > max_count) {
            max_count = current_count;
            modes.Clear();
            modes.Add(node.val);
        }
        current_val = node.val;

        in_order_traversal(node.right);
    }
}