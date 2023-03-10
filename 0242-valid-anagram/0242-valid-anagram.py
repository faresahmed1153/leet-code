class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
            if len(s) !=len(t):
                return False
    
            ds,dt=Counter(s),Counter(t)
    
            if ds != dt:
                return False
    
            return  True
      