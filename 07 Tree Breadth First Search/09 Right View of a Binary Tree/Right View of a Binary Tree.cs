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
    public IList<int> RightSideView(TreeNode root) {
        var nodes = new List<int>();
        var queue = new Queue<TreeNode>();
        
        if (root != null) queue.Enqueue(root);
        
        while (queue.Count > 0) {
            int levelCount = queue.Count;
            
            for (int i = 0; i < levelCount; i++) {
                var node = queue.Dequeue();
                
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
                if (i == levelCount - 1)
                    nodes.Add(node.val);
            }
        }
        return nodes;
    }
}