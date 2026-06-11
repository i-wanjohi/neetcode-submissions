public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {

        // start a string at every index, and keep extending it until we see a repeated character
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // hash set to store substrinng of what we've seen so far
            HashSet<char> charSet = new();

            // new starting point (j = i)
            for (int j = i; j < s.Length; j++)
            {
                // when duplicate appears, substring can't grow anymore
                if (charSet.Contains(s[j])) break;

                charSet.Add(s[j]);

                result = Math.Max(result, charSet.Count());
            }
        }

        return result;
    }
}
