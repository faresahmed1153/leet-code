public class Solution {
    public int ClosetTarget(string[] words, string target, int startIndex) {
        int left = 0;
			int right = 0;
        int moves = 0;
        if (!words.Contains(target))
				return -1;
        if(words[startIndex]==target)
            return 0;
        
			for (int i = startIndex; moves < words.Length; i++)
			{
				if (words[(i + 1) % words.Length] == target)
				{
					right++;
					break;
				}

				else
				{
					right++;
					moves++;
				}

			}

			for (int i = startIndex; moves < words.Length; i--)
			{

				if (words[(i - 1 + words.Length) % words.Length] == target)
				{
					left++;
					break;
				}
				else
				{
					left++;
					moves++;
				}

			}
			return right <= left ? right : left;
    }
}