class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        dt={}
    
        for i, num in enumerate(nums):
            diff= target-nums[i]
            
            if diff in dt:
                return([dt[diff],i])
            dt[num]=i