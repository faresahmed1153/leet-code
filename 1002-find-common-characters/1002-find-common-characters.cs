
public class Solution {
    public IList<string> CommonChars(string[] words) {
      List<char> CommonChars = new List<char>(words[0]);
            List<char> list = new List<char>(words[0]);


            for (int i = 1; i < words.Length; i++)
            {

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (list.Contains(words[i][j]))
                        list.Remove(words[i][j]);
                    else
                        list.Remove(words[i][j]);
                }
                for (int k = 0; k < list.Count; k++)
                {
                    CommonChars.Remove(list[k]);
                }
                list.Clear();
                list.AddRange(CommonChars);


            }
            return CommonChars.Select(c => c.ToString()).ToList();
    }
}