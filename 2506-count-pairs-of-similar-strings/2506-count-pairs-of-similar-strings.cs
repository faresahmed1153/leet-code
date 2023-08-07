public class Solution {
    public int SimilarPairs(string[] words) {
          int similarPairs = 0;
            string[] list= new string[words.Length];
            for (int i = 0; i < words.Length; i++)

                list[i]=(string.Concat(words[i].ToCharArray().Distinct()));
   
            for (int i = 0; i < list.Length; i++)
            {

                for (int j = i + 1; j < list.Length; j++)
                

                    if (string.Concat(list[i].OrderBy(x => x)) == string.Concat(list[j].OrderBy(x => x)))
                    
                        similarPairs++;
            }
            return similarPairs;
    }
}