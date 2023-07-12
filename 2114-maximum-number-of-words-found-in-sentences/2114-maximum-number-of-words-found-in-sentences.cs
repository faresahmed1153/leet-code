public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                int current = sentences[i].Split(" ").Length;
                if (current > max)
                    max = current;
            }
            return max;
    }
}