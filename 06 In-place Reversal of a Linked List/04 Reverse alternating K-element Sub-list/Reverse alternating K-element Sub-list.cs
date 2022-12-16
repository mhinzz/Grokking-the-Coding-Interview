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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(head == null) return null;
        ListNode current  = head;
        ListNode next = null;
        ListNode prev = null;
        int count =0;

        int length  = GetLength(head);
        if(length< k) return head;
        
        while(count < k && current!=null) {
            count++;
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        
        if(next !=null)
            head.next = ReverseKGroup(next, k);

        return prev;
    }
    
    public int GetLength(ListNode head) {
        int count = 0;
        
        ListNode current = head;
        while(current!=null) {
            count++;
            current = current.next;
        }
         
        return count;
    }
}