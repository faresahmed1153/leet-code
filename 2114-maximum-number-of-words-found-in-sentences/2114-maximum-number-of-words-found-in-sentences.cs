public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] splitted = sentences[i].Split(" ");
                int current = splitted.Length;
                if (current > max)
                    max = current;
            }
            return max;
    }
}