/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null || head.next == null)
            return true;
        return IsPalindromeTwo(ref head, head.next);
    }
    
    private bool IsPalindromeTwo(ref ListNode left, ListNode right) {
        if (right.next == null)
            return left.val == right.val;
        bool res = IsPalindromeTwo(ref left, right.next);
        left = left.next;
        return res && left.val == right.val;
    }
}