namespace DefaultNamespace;

public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hashSet = nums.ToHashSet();
        if (nums.Length != hashSet.Count) return true;
        return false;
    }
}