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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null)
            return null;
        
        int len = lists.Length;
        if (len == 0)
            return null;
        if (len == 1)
            return lists[0];
        
        ListNode head = lists[0];
        
        for (int i = 1; i < len; i++) {
            if (lists[i] == null)
                continue;
            head = Merge2Lists(head, lists[i]);
        }
        
        return head;
    }
    
    private ListNode Merge2Lists(ListNode head1, ListNode head2) {
        ListNode temp = new ListNode(0);
        ListNode current = temp;
        
        while (head1 != null && head2 != null) {
            if (head1.val < head2.val) {
                current.next = head1;
                head1 = head1.next;
            } 
            else {
                current.next = head2;
                head2 = head2.next;
            }
            current = current.next;
        }
        
        current.next = (head1 == null) ? head2 : head1;
        
        return temp.next;
    }
}