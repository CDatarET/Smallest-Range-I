public class Solution {
    public int SmallestRangeI(int[] nums, int k) {
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        for(int i = 0; i < nums.Length; i++){
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
        }

        if(min + k >= max - k) return 0;
        else return (max - k) - (min + k);
    }
}
