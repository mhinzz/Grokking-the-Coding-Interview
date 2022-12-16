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
    public int MaxPathSum(TreeNode root) {
        if(root == null)
            return 0;
        int maxSum = int.MinValue;
        MaxPathSumHelper(root, ref maxSum);
        return maxSum;
    }

    public int MaxPathSumHelper(TreeNode root, ref int maxSum){
        if(root == null)
            return 0; 
        int leftSum = MaxPathSumHelper(root.left, ref maxSum);
        int rightSum = MaxPathSumHelper(root.right, ref maxSum);
        int closedPathSum = root.val;
        bool onePositiveChild = false;
        if(leftSum > 0){
            closedPathSum += leftSum;
            onePositiveChild = true;
        }
        if(rightSum > 0){
            closedPathSum += rightSum;
            onePositiveChild = true;
        }
        if(closedPathSum >  maxSum)
            maxSum = closedPathSum;
        int openedPathSum = root.val;
        if(onePositiveChild)
            openedPathSum += (leftSum > rightSum? leftSum : rightSum); 
        return openedPathSum;
    }
}