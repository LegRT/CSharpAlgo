public class Solution {
    public void MoveZeroes(int[] nums)
    {
        int left = 0;
        int right = 1;
        while (right != nums.Length - 1)
        {
            if (nums[left] != 0)
            {
                left++;
                right++;
                continue;left
            }
            else
            {
                if (nums[right] != 0)
                {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                }
                else
                {
                    right++;
                    continue;
                }
            }
            left++;
            right++;
        }
    }
}