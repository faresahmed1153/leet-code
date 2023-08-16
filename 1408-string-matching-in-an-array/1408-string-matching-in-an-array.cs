public class Solution {
    public IList<string> StringMatching(string[] words) {
        List<string> StringMatching = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Contains(words[j]))
                        StringMatching.Add(words[j]);
                    else
                    {
                        if (words[j].Contains(words[i]))
                            StringMatching.Add(words[i]);
                    }
                }
            }
            return StringMatching.Distinct().ToList();
    }
}