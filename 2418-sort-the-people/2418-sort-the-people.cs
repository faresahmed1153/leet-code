public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
  SortedDictionary<int, string> people = new SortedDictionary<int, string>(Comparer<int>.Create((a, b) => b - a));
            for (int i = 0; i < names.Length; i++)
            {
                people.Add(heights[i], names[i]);
            }
            string[] sortedNames = people.Select(x => x.Value).ToArray();

            return sortedNames;
}
}