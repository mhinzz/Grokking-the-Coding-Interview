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
    public IList<TreeNode> GenerateTrees(int n) {
        return generateTree_helper(1, n);
    }

    private IList<TreeNode> generateTree_helper(int left, int right) {
        IList<TreeNode> treeNodes = new List<TreeNode>();
        if (left >= right) {
            if (left == right) {
                TreeNode treeNode = new TreeNode(left, null, null);
                treeNodes.Add(treeNode);
            }
            else {
                treeNodes.Add(null);
            }
            return treeNodes;
        }

        for (int i = left; i <= right; i++) {
            IList<TreeNode> leftNodes = generateTree_helper(left, i - 1);
            IList<TreeNode> rightNodes = generateTree_helper(i + 1, right);
            foreach (TreeNode leftNode in leftNodes) {
                foreach (TreeNode rightNode in rightNodes) {
                    TreeNode node = new TreeNode(i, leftNode, rightNode);
                    treeNodes.Add(node);
                }
            }
        }
        return treeNodes;
    }
}