public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
        
        foreach (var str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);
            
            if (!groups.ContainsKey(sorted)) {
                groups[sorted] = new List<string>();
            }
            
            groups[sorted].Add(str);
        }
        
        return new List<List<string>>(groups.Values);
    }
}