public class Solution {
    public int MaximumValue(string[] strs) {
        int maxOfDigit = 0;
            int maxOfAlphanumeric = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                if (int.TryParse(strs[i], out int parsed))
                {
                    if (parsed > maxOfDigit)
                        maxOfDigit = parsed;
                }

                else
                    if (strs[i].Length > maxOfAlphanumeric)
                    maxOfAlphanumeric = strs[i].Length;

            }
            int result = maxOfDigit >= maxOfAlphanumeric ? maxOfDigit : maxOfAlphanumeric;
            return result;
    }
}