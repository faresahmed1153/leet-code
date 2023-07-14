public class MyQueue
        {

            LinkedList<int> obj;
            public MyQueue()
            {
                obj = new LinkedList<int>();
            }

            public void Push(int x)
            {
                obj.AddLast(x);
            }

            public int Pop()
            {
                int first = obj.First();
                obj.RemoveFirst();
                return first;
            }

            public int Peek()
            {
                return obj.First();
            }

            public bool Empty()
            {
                return obj.First == null;
            }

        }

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */