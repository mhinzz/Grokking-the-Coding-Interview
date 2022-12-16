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
    public IList<double> AverageOfLevels(TreeNode node) {
        List<double> averageValues = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(node);

        while (queue.Any()) {
            var countOnCurrentLevel = queue.Count;
            averageValues.Add(0);
            for (var _ = 0; _ < countOnCurrentLevel; _++) {
                node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
                averageValues[^1] += node.val;
            }
            averageValues[^1] /= countOnCurrentLevel;
        }
        return averageValues;
    }
}