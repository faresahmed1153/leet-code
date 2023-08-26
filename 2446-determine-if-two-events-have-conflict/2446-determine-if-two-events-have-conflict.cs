public class Solution {
    public bool HaveConflict(string[] event1, string[] event2) {
        bool HaveConflict = false;
           if (event1[0].CompareTo(event2[0]) == 1)
            {
                if (event1[0].CompareTo(event2[1]) != 1)
                    HaveConflict = true;
            }

            else
            {
                if (event2[0].CompareTo(event1[1]) != 1)
                    HaveConflict = true;
            }
            return HaveConflict;
    }
}