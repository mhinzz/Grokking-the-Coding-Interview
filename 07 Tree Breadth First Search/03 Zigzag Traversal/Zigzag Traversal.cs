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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if (root == null)
            return result;
        Queue<(TreeNode Node, int Level)> queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root,0));
        while (queue.Count > 0) {
            var pair = queue.Dequeue();
            if (result.Count <= pair.Level)
                result.Add(new List<int>());
            result[pair.Level].Add(pair.Node.val);
            if (pair.Node.left != null)
                queue.Enqueue((pair.Node.left, pair.Level+1));
            if (pair.Node.right != null)
                queue.Enqueue((pair.Node.right, pair.Level+1));
        }
        for (int i = 0; i < result.Count; i++) {
            if (i % 2 == 1) {
                ((List<int>)result[i]).Reverse();
            }
        }
        return result;
    }
}