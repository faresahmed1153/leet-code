public class Solution {
    public string OddString(string[] words) {
            Dictionary<List<int>, int> uniqueList = new Dictionary<List<int>, int>();
            List<int> list = new List<int>();
            List<int> foundBefore = new List<int>();


            for (int i = 0; i < words.Length; i++)
            {

                for (int j = 0; j < words[i].Length - 1; j++)
                {
                    list.Add(words[i][j + 1] - words[i][j]);
                }

                if (foundBefore.SequenceEqual(list))
                {
                    list.Clear();
                    continue;
                }

                if (uniqueList.Any(l => l.Key.SequenceEqual(list)))
                {
                    var repeated = uniqueList.Where(l => l.Key.SequenceEqual(list));
                    uniqueList.Remove(repeated.ElementAt(0).Key);
                    foundBefore = list.ToList();
                    list.Clear();
                }
                else
                {
                    uniqueList.Add(list.ToList(), i);
                    list.Clear();
                }

            }
            return words[uniqueList.ElementAt(0).Value];
    }
}