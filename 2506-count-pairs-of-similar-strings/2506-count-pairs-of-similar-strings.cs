public class Solution {
    public int SimilarPairs(string[] words) {
         int similarPairs = 0;
            string[] list = new string[words.Length];
            for (int i = 0; i < words.Length; i++)

                list[i] = (string.Concat(words[i].ToCharArray().Distinct().OrderBy(x => x)));
      
            for (int i = 0; i < list.Length; i++)
            {

                for (int j = i + 1; j < list.Length; j++)


                    if (list[i] == list[j])

                        similarPairs++;
            }
            return similarPairs;
    }
}