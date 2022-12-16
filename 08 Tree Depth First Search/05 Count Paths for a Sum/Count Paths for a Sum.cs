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
    int result = 0;
    public int PathSum(TreeNode root, int targetSum) {        
        if (root == null)
            return result;
        if (targetSum == root.val)
            result++;    
        PathSumHelper(root.left,targetSum - root.val);
        PathSumHelper(root.right,targetSum - root.val);
        PathSum(root.left,targetSum);
        PathSum(root.right,targetSum);
        return result;
    }
    
    public void PathSumHelper(TreeNode root, long targetSum) {
        if (root == null)
            return;
        if (targetSum == root.val)
            result++;
        PathSumHelper(root.left, targetSum - root.val);
        PathSumHelper(root.right, targetSum - root.val);
        return;
    }
}