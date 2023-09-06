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
    public ListNode[] SplitListToParts(ListNode head, int k) 
    {
        ListNode[] res = new ListNode[k];
        int sizeEachPart = 1;
        int size = CountNodes(head);
        int redundancies = 0;
        if (size > k)
        {
            sizeEachPart = size / k;
            redundancies = size % k;
        }

        for (int i = 0; i < k; i++)
        {
            ListNode addItem = head;
            int count = 1;

            while (count < sizeEachPart && head != null)
            {
                head = head.next;
                count++;
            }

            if (redundancies > 0 && head != null)
            {
                head = head.next;
                redundancies--;
            }

            ListNode next = null;
            if (head != null)
            {
                next = head.next;
                head.next = null;
            }
            res[i] = addItem;
            head = next;
        }

        return res;
    }

    private int CountNodes(ListNode head)
    {
        ListNode root = head;
        int count = 0;

        while (root != null)
        {
            count++;
            root = root.next;
        }

        return count;
    }
}