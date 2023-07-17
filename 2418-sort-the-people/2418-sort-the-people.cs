public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
Dictionary<int, string> people = new Dictionary<int, string>();
            for (int i = 0; i < names.Length; i++)
            {
                people.Add(heights[i], names[i]);
            }
            string[] sorted = people.OrderByDescending(x => x.Key).Select(x => x.Value).ToArray();

            return sorted;
}
}