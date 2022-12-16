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
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null)
			return false;

	    var stack = new Stack<(TreeNode Node, int Sum)>();
	    stack.Push((root, root.val));
	    while (stack.Count != 0) {
		    var p = stack.Pop();
            TreeNode node = p.Node;
            int psum = p.Sum;
            
			if (node.right != null)
		        stack.Push((node.right, node.right.val+psum));			
			if (node.left != null)
				stack.Push((node.left, node.left.val+psum));
			if (node.left == null && node.right == null && psum == sum)
                return true;
        }
        return false;
    }
}