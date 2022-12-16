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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var queue = new List<TreeNode>(){root};
        var res = new List<IList<int>>();

        while(queue.Count > 0) {
            res.Add((from node in queue where node != null select node.val).ToList());
           queue = (from node in queue where node !=null from child in new List<TreeNode>(){node.left, node.right} select child).ToList();
        }
        
        return Enumerable.Reverse(res).Skip(1).ToList();
    }
}