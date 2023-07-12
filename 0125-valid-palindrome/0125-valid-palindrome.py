class Solution:
    def isPalindrome(self, s: str) -> bool:
        alphanumeric = ''.join(filter(str.isalnum, s)).lower()
        reversed=alphanumeric[::-1]
        if alphanumeric == reversed:
            return True
        return False