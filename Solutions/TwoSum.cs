namespace DefaultNamespace;

public class Solution {
    
    public int[] TwoSum(int[] nums, int target)
    {
        int index = 0;
        Dictionary<int, int> checker = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            bool added = checker.TryAdd(num, index);
            if (!added)
            {
                checker[num] = index;
            }
            index++;
        }
        index = 0;
        foreach (var num in nums)
        {
            int target_num = target - num;
            if (checker.ContainsKey(target_num) && checker[target_num] != index)
            {
                int ans_index = checker[target_num];
                return new [] { index, ans_index };
            }
            
            index++;
        }
        
        return new [] { -1, -1 };
    }
}