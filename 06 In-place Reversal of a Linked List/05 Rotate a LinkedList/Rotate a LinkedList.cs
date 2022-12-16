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
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null) return head;
        
        int count = 1;
        ListNode tail = head;
        while (tail.next != null) {
            tail = tail.next;
            count++;
        }
        
        k = k % count;
        if (k == 0) return head;
        
        ListNode node = head;
        int shift = count - k - 1;
        while (shift-- > 0) node = node.next;
        
        tail.next = head;
        head = node.next;
        node.next = null;
        
        return head;
    }
}