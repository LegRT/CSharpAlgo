namespace DefaultNamespace;

public class Solution {
    
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> firstCount = new Dictionary<char, int>();
            Dictionary<char, int> secondCount = new  Dictionary<char, int>();
            foreach (var ch in s)
            {
                if (!firstCount.TryAdd(ch, 1))
                {
                    firstCount[ch]++;
                }
            }

            foreach (var ch in t)
            {
                if (!secondCount.TryAdd(ch, 1))
                {
                    secondCount[ch]++;
                }
            }
            
            {
                
            }

            if (firstCount.Count != secondCount.Count) return false;
            foreach (var ch in firstCount)
            {
                if (!secondCount.ContainsKey(ch.Key) || firstCount[ch.Key] != secondCount[ch.Key])
                {
                    return false;
                }
            }

            return true;

        }
}
