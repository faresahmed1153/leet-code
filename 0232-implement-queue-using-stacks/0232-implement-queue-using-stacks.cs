public class MyQueue
        {

            public Stack<int> stack;
            public Stack<int> stack2;

            public MyQueue()
            {
                stack = new Stack<int>();
                stack2 = new Stack<int>();
            }

            public void Push(int x)
            {

                stack.Push(x);
                stack2.Clear();
                for (int i = 0; i <stack.Count ; i++)
                {
                    stack2.Push(stack.ElementAt(i));
                }
            }

            public int Pop()
            {

               
                stack.Clear();
                int removed = stack2.Pop();
                for (int i = 0; i < stack2.Count; i++)
                {
                    stack.Push(stack2.ElementAt(i));
                }

                return removed;
            }

            public int Peek()
            {
                
                return stack2.FirstOrDefault();
            }

            public bool Empty()
            { 
                return stack2.Count == 0;
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