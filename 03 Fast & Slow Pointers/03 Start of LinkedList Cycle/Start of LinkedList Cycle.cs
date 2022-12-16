/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;
        
        while(fast != null && slow != null && fast.next != null) {   
            if(fast.next.next == null)
                return null;
                
            slow = slow.next; 
            fast = fast.next.next;
            
            if(fast == slow) {
                while( head != slow) {
                    head = head.next;
                    slow = slow.next;
                }
                return slow;
            }            
        }
        return null;
    }
}