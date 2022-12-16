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
        public void ReorderList(ListNode head) {
            ListNode fastHead = head,
                     slowHead = head;

            while (fastHead != null && fastHead.next != null) {
                fastHead = fastHead.next.next;
                slowHead = slowHead.next;
            }

            var temp = slowHead.next;
            while (temp != null) {
                var temp2 = temp.next;
                temp.next = slowHead;
                slowHead = temp;
                temp = temp2;
            }

            ListNode leftHead = head,
                     rightHead = slowHead;
            while (leftHead != rightHead && leftHead.next != rightHead) {
                var tempLeft = leftHead.next;
                var tempRight = rightHead.next;
                leftHead.next = rightHead;
                rightHead.next = tempLeft;
                leftHead = tempLeft;
                rightHead = tempRight;
            }            
            rightHead.next = null;            
        }
}