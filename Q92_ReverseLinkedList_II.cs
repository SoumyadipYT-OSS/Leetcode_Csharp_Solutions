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
public class Solution
{
    public ListNode? ReverseBetween(ListNode head, int left, int right)
    {
        if (left == right) return head;

        var dummyHead = new ListNode(-501, head);
        var current = dummyHead.next;
        var direct = dummyHead;
        ListNode? reverse = null;
        ListNode? rightSideReverse = null;
        int count = 0;

        while (current != null)
        {
            count++;

            if (count < left)
            {
                var node = new ListNode(current.val);
                direct!.next = node;
                direct = direct.next;
            }
            else if (count >= left && count <= right)
            {
                var node = new ListNode(current.val, reverse);

                if (count == left)
                {
                    rightSideReverse = node;
                }

                reverse = node;
            }
            else
            {
                if (count == right + 1)
                {
                    direct.next = reverse;
                }
                
                var node = new ListNode(current.val);
                rightSideReverse!.next = node;
                rightSideReverse = rightSideReverse.next;
            }

            current = current.next;
        }

        if (right == count)
        {
            if (left == 1)
            {
                return reverse;
            }
            else
            {
                direct.next = reverse;
            }
        }

        return dummyHead.next;
    }
}