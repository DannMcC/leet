public class Solution {

    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<int, string> hashMap = new Dictionary<int, string>();
        char[] charArray;
        charArray = s.ToCharArray();
        string currentSubstring;
        currentSubstring = "";
        for (int i = 0; i < charArray.Length; i++)
        {
            char currentChar = charArray[i];
            string charAsString = currentChar.ToString();
            bool hashMapContainsChar = hashMap.ContainsValue(charAsString);
            bool charInSubstring = currentSubstring.Contains(charAsString);
            if (currentSubstring  == "")
            {
                hashMap[1] = charAsString;
                currentSubstring += charAsString;
            }
            else if (!charInSubstring)
            {
                Console.WriteLine(currentSubstring);
                currentSubstring += charAsString;
                hashMap[currentSubstring.Length] = charAsString;
            }
            else if (charInSubstring)
            {
                int index = currentSubstring.IndexOf(charAsString);
                currentSubstring = currentSubstring.Remove(0, index);
                hashMap[currentSubstring.Length] = currentSubstring;
            }

        }
        return hashMap.Count;
    }
}