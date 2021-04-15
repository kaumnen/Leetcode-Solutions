class Solution:
    def arraySign(self, nums: List[int]) -> int:
        result = 1
        for i in nums:
            if i == 0:
                return 0
            result *= i
        return 1 if result > 0 else -1