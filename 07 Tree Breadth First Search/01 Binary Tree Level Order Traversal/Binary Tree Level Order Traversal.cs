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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        var queue = new Queue<Tuple<TreeNode, int>>();
        
        if(root != null)
            queue.Enqueue(new Tuple<TreeNode, int>(root, 0));
            
        while (queue.Count() > 0) {
            var nodeKvp = queue.Dequeue();
            var node = nodeKvp.Item1;
            var level = nodeKvp.Item2;
            
            if (res.Count() > level)
                res[level].Add(node.val);
            else
                res.Add(new List<int>() { node.val });
                
            if (node.left != null)
                queue.Enqueue(new Tuple<TreeNode, int>(node.left, level + 1));
            if (node.right != null)
                queue.Enqueue(new Tuple<TreeNode, int>(node.right, level + 1));
        }
        return res;
    }
}