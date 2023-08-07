public class Solution {
    public int SimilarPairs(string[] words) {
           int similarPairs = 0;
            LinkedList<string> list = new LinkedList<string>();
            for (int i = 0; i < words.Length; i++)

                list.AddFirst(string.Concat(words[i].ToCharArray().Distinct()));
   

            for (int i = 0; i < list.Count; i++)
            {

                for (int j = i + 1; j < list.Count; j++)
                

                    if (string.Concat(list.ElementAt(i).OrderBy(x => x)) == string.Concat(list.ElementAt(j).OrderBy(x => x)))
                    
                        similarPairs++;
            }
            return similarPairs;
    }
}