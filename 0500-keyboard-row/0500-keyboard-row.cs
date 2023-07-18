public class Solution {
    public string[] FindWords(string[] words) {
        string firstRow = "qwertyuiop";
            string secondRow = "asdfghjkl";
            string thirdRow = "zxcvbnm";
            bool flag;
        string[] lowered = words.Select(x => x.ToLower()).ToArray();


            for (int i = 0; i < lowered.Length; i++)
            {
                for (int j = 0; j < lowered[i].Length; j++)
                {
                    if (firstRow.Contains(lowered[i][0]))
                    {
                        flag = firstRow.Contains(lowered[i][j]);
                        if (!flag)
                        {
                            words.SetValue("-1", i);

                            break;

                        }

                    }
                    else if (secondRow.Contains(lowered[i][0]))
                    {
                        flag = secondRow.Contains(lowered[i][j]);
                        if (!flag)
                        {
                            words.SetValue("-1", i);
                            break;
                        }

                    }
                    else
                    {
                        flag = thirdRow.Contains(lowered[i][j]);
                        if (!flag)
                        {
                            words.SetValue("-1", i);
                            break;
                        }
                    }
                }
            }
            string[] result = words.Where(x => x != "-1").ToArray();
            return result;
    }
}