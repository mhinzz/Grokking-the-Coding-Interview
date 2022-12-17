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
public class BSTIterator {
    Stack<TreeNode> st;
    public BSTIterator(TreeNode root) {
        st = new Stack<TreeNode>();
        PopulateStack(root);
    }

    private void PopulateStack(TreeNode root) {
        while (root != null) {
            st.Push(root);
            root = root.left;
        }
    }

    public int Next() {
        var root = st.Pop();
        var val = root.val;

        root = root.right;
        PopulateStack(root);
        return val;
    }

    public bool HasNext() {
        return st.Count() > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */