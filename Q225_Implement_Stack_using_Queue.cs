public class MyStack {
    Queue<int> queue;
    Queue<int> reverse;
    int top;

    public MyStack() {
        queue = new();
        reverse = new();
    }
    
    public void Push(int x) {
        queue.Enqueue(x);
        top = x;
    }
    
    public int Pop() {
        while(queue.Count > 1){
            top = queue.Dequeue();
            reverse.Enqueue(top);
        }
        int popVal = queue.Dequeue();
        (queue,reverse) = (reverse,queue);
        return popVal;
    }
    
    public int Top() {
        return top;
    }
    
    public bool Empty() {
        return queue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */