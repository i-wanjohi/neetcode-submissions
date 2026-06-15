public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        // for each substring - 
        // - count character frequencies
        // - find most frequent character
        // - calculate replacements needed (s.Length - most frequent char)
        // - if replacements needed <= k, update longest length  

        int longest = 0;

        for (int i = 0; i < s.Length; i++)            // starting position
        {
            Dictionary<char, int> count = new();     // tracks how many times each character appears in substring
            int maxFrequency = 0;                    // tracks most frequent character

            for (int j = i; j < s.Length; j++)       // end of substring
            {
                if (count.ContainsKey(s[j]))         // count.ContainsKey('A')
                {
                    count[s[j]]++;                   // e.g. count['A']++
                } else
                {
                    count[s[j]] = 1;                 // e.g. count['A'] = 1
                }
                maxFrequency = Math.Max(maxFrequency, count[s[j]]);

                if ((j - i + 1) - maxFrequency <= k)    // if (length - maxFrequency)
                {
                    longest = Math.Max(longest, (j-i+1));
                }
            }
        } 

        return longest;
    }
}
