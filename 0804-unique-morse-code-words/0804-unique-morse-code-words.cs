public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
      string letters = "abcdefghijklmnopqrstuvwxyz";
            string[] lettersInMorse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            Dictionary<char, string> dictionary = new Dictionary<char, string>();
            HashSet<string> transformations = new HashSet<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < letters.Length; i++)
            {
                dictionary.Add(letters[i], lettersInMorse[i]);
            }
           
           
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    dictionary.TryGetValue(words[i][j], out string charTransform);
                    sb.Append(charTransform);
                }
                transformations.Add(sb.ToString());
                sb.Clear();
            }
            return transformations.Count();
    }
}