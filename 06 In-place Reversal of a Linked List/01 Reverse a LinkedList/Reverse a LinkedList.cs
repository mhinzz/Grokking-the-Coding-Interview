/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode previous = null, next = head;
        
        while (next != null) {
            ListNode current = next, nextNext = next.next;
            current.next = previous;
            previous = current;
            next = nextNext;
        }
        return previous;
    }
}