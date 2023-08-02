public class Solution {
    public int[] ShortestToChar(string s, char c) {
        int distance;
			List<int> indexes = new List<int>();
			List<int> answer = new List<int>();

			for (int i = 0; i < s.Length; i++)
				if (s[i] == c)
					indexes.Add(i);


			for (int i = 0; i < s.Length; i++)
			{
				distance = Math.Abs(i - indexes[0]);
				for (int j = 0; j < indexes.Count; j++)
				{

					if (Math.Abs(i - indexes[j]) < distance)
						distance = Math.Abs(i - indexes[j]);
				}
				answer.Add(distance);
			}
        return answer.ToArray();
    }
}