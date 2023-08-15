public class Solution {
    public int MinOperations(string[] logs) {
        int MinOperations = 0;
            for (int i = 0; i < logs.Length; i++)
            {
                if (logs[i] != "../" && logs[i] != "./")
                    MinOperations++;

                else if (logs[i] == "../")
                    if (MinOperations > 0)
                        MinOperations--;


            }
            return MinOperations;
    }
}