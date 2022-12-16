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
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        if (root == null)
			return new List<IList<int>>();

        var result = new List<IList<int>>();
	    var stack = new Stack<(TreeNode Node, int Sum, int Index)>();
        var path = new List<int>();
	    stack.Push((root, root.val, 0));
	    while (stack.Count != 0) {
		    var p = stack.Pop();
            TreeNode node = p.Node;
            int psum = p.Sum;
            int index = p.Index;
            
            if (index < path.Count)
                path[index] = node.val;
            else
                path.Add(node.val);
            
			if (node.right != null)
		        stack.Push((node.right, node.right.val+psum, index+1));			
			if (node.left != null)
				stack.Push((node.left, node.left.val+psum, index+1));
            
            if (node.right == null && node.left == null && psum == sum)
                result.Add(path.GetRange(0, index+1));
        }
        return result;
    }
}