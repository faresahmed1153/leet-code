public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
          HashSet<char> letter = new HashSet<char>();
           List<string> list = new List<string>(words);
            for (int i = 0; i < allowed.Length; i++)

                letter.Add(allowed[i]);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!letter.Contains(words[i][j]))
                    {
                        list.Remove(words[i]);
                        break;
                    }

                }
            }

            return list.Count;
    }
}