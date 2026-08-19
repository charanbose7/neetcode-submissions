public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        
        foreach(var num in nums) {
            if(!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }
        
        return freq.OrderByDescending(x => x.Value)  // Sort by count descending
                   .Take(k)                           // Get first k
                   .Select(x => x.Key)                // Extract just the numbers
                   .ToArray();
    }
}