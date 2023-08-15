public class Solution {
    public int MinOperations(string[] logs) {
        Stack<int> st = new Stack<int>();
        for(int i =0 ;i< logs.Length;i++)
        {
            
            if(logs[i] == "../")
            {
                if(st.Count != 0)
                {
                    st.Pop();
                }
            }else if(logs[i] == "./")
            {
                continue;
            }else
            {
                st.Push(0);
            }
        }    

        return st.Count;
    }
}