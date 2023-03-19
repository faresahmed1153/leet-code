public class Solution {
    public bool IsPalindrome(int x) {
         if (x < 0)
                return false;
            else
            {

                int reversedNum = 0, number = x, reminder;
                while (number != 0)
                {
                    reminder = number % 10;
                    reversedNum = reversedNum * 10 + reminder;
                    number /= 10;
                }
                if (x == reversedNum)
                    return true;
                else
                    return false;
            }
    }
}