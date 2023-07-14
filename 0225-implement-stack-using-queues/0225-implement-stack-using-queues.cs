public class MyStack
        {
            LinkedList<int> obj;
            public MyStack()
            {
                obj= new LinkedList<int>();
            }

            public void Push(int x)
            {
                obj.AddLast(x);
            }

            public int Pop()
            {
                int last = obj.Last();
                obj.RemoveLast();
                return last;
            }

            public int Top()
            {
                return obj.Last();
            }

            public bool Empty()
            {
                return obj.First == null;
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