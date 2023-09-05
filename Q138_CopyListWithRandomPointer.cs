/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    
     public Node CopyRandomList(Node head) {
         if ( head == null){
             return null;
         }
         Dictionary<Node,Node> dict = new ();
         var current = head;
         while ( current != null){
             dict[current] = new Node(current.val);
             current = current.next;
         }
         Node newHead = new Node(0);
         Node temp = newHead;
         current = head;
         while ( current != null){
             temp.next= dict[current];
             if ( current.random != null){
                 temp.next.random = dict[current.random];
             }
             temp = temp.next;
             current = current.next;
         }
         temp.next = null;
         return newHead.next;
     }
    public Node CopyRandomLis1t(Node head) {
        Node current = head;
        while ( current != null){
            Node temp = new Node(current.val);
            temp.next = current.next;
            current.next = temp;
            current = current.next.next;
        }    
        current = head;
        while ( current != null){
            if ( current.random != null){
                current.next.random = current.random.next;
            }
            current = current.next.next;
        }

        Node newHead = new Node(0);
        Node next = newHead;
        current = head;
        while ( current != null){
            next.next = current.next;
            next = next.next;
            current.next = current.next.next;
            current = current.next;
        }
        return newHead.next;        
    }
}