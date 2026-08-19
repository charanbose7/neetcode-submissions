public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var str in strs)
        {
            sb.Append(str).Append("`");
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> decodedStrings = new List<string>();
        int wordStartIndex = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '`')
            {
                decodedStrings.Add(s.Substring(wordStartIndex, i - wordStartIndex));
                wordStartIndex = i+1;
            }
        }
        return decodedStrings;
   }
}