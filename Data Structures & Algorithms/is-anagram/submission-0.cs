public class Solution {
    public bool IsAnagram(string s, string t) 
    
    {
        if (s.Length != t.Length) { return false; }
       
        char[] sLetters = s.ToCharArray();
        char[] tLetters = t.ToCharArray();
       
        Array.Sort(sLetters);
        Array.Sort(tLetters);

        return sLetters.SequenceEqual(tLetters);
    }
}
