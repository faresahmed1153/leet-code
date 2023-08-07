public class Solution {
    public int SimilarPairs(string[] words) {
      int similarPairs = 0;
            List<string> list = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                list.Add(string.Concat(words[i].ToCharArray().Distinct()));
            }
            
            for (int k = 0; k < list.Count; k++)
            {

                for (int i = k + 1; i < list.Count; i++)
                {

                    string x = string.Concat(list[k].OrderBy(x => x));
                    string y = string.Concat(list[i].OrderBy(x => x));
                    if (x == y)
                    {
                        similarPairs++;
                    }

                }
            }
            return similarPairs;
    }
}