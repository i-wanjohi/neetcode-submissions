public class Solution {
    public bool IsPalindrome(string s) 
    {
        string cleanString = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");

        char[] chars = cleanString.ToArray();
        Array.Reverse(chars);

        string reversed = new string(chars);

        return cleanString == reversed;
    }
}
