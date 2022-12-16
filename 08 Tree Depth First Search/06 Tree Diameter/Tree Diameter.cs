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
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null) return 0;
        
        int[] ans = Dfs(root);
        return Math.Max(ans[0] - 1, ans[1]);
        
        int[] Dfs(TreeNode node) {
            if(node.left == null && node.right == null) return new int[]{ 0, 0 };
            int[] l = new int[2];
            int[] r = new int[2];
            int ch = 0;
            
            if(node.left != null) {
                l = Dfs(node.left);
                ch += 1;
            }
            if(node.right != null) {
                r = Dfs(node.right);
                ch += 1;
            }
            return new int[]{ Math.Max(l[0], r[0]) + 1, Math.Max(Math.Max(l[1], r[1]), l[0] + r[0] + ch)};
        }
    }
}