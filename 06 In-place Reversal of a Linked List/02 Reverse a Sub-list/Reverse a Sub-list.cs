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
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        if (m == n) return head;
            ListNode curr = head, prev = null;
            for(int i=0;i<m-1 && curr != null; i++) {
                prev = curr;
                curr = curr.next;
            }
            ListNode lastNodeOfFirstPart = prev;
            ListNode lastNodeOfSubList = curr;

            ListNode next = null;
            for (int i = 0;curr!=null && i < n - m + 1; i++) {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            if (lastNodeOfFirstPart != null)
                lastNodeOfFirstPart.next = prev;
            else head = prev;
            
            lastNodeOfSubList.next = curr;

            return head;
    }
}