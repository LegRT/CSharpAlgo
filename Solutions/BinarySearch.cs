public class Solution {
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        if (nums.Length == 1)
        {
            return nums[0] ==  target ? 0 : -1;
        }
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return -1;
    }
}