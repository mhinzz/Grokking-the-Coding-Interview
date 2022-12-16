/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        Connect(null, root, true);
        return root;
    }
    
    private void Connect(Node parent, Node node, bool isLeft) {
        if (node != null) {
            node.next = isLeft ? parent?.right : parent?.next?.left;
            Connect(node, node.left, true);        
            Connect(node, node.right, false);
        }
    }    
}