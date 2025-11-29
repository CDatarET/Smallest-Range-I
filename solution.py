class Solution:
    def smallestRangeI(self, nums, k):
        down = min(nums)
        up = max(nums)

        if down + k >= up - k : return 0
        else : return (up - k) - (down + k)
