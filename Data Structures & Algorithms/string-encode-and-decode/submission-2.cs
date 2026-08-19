public class Solution {

    public string Encode(IList<string> strs) {
        string encodedmessage = "";
        foreach(var str in strs)
        {
            encodedmessage += str.ToString() + "`";
        }
        return encodedmessage;
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