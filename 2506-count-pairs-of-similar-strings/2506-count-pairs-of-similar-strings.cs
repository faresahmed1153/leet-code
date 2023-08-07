public class Solution {
    public int SimilarPairs(string[] words) {
      int similarPairs = 0;
            List<string> list = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                list.Add(string.Concat(words[i].ToCharArray().Distinct()));
            }

            for (int i = 0; i < list.Count; i++)
            {

                for (int j = i + 1; j < list.Count; j++)
                

                    if (string.Concat(list[i].OrderBy(x => x)) == string.Concat(list[j].OrderBy(x => x)))
                    
                        similarPairs++;
            }
            return similarPairs;
    }
}