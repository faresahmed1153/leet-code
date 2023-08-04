public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
          HashSet<char> letter = new HashSet<char>();
            int count = 0;
            for (int i = 0; i < allowed.Length; i++)

                letter.Add(allowed[i]);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!letter.Contains(words[i][j]))
                    {
                        count++;
                        break;
                    }

                }
            }

            return words.Length-count;
    }
}