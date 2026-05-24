public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        // anagrams will produce the same string when their characters are sorted
        // sort each words letters
        // use that as a label
        // group words with the same label together

        var result = new Dictionary<string, List<string>>();     
        // key is a sorted string - holds a list of words that are anagrams of each other
        // key - a box to keep all words with the same letters after sorting
        // e.g. for key(box) "aet" - you can put in the words "tea", "ate", "eat"
        // if you pick up box with no existing label, create it and then drop the words with similar letters in that box
        // e.g. for key(box) "bat" - put words "bat", "tab" 

        foreach (var word in strs) // loop through every word in the string array
        {
            char[] lettersInWord = word.ToCharArray(); // e.g. will break eat into ['e', 'a', 't']
            Array.Sort(lettersInWord); // rearranges back to ['a', 'e', 't']
            string sortedWord = new string(lettersInWord); // glues it back to "aet"

            if (!result.ContainsKey(sortedWord)) // if dictionary doesn't already have a key(box) labelled "aet"...
            {
                result[sortedWord] = new List<string>(); // ...create one with an empty list inside
            }

            result[sortedWord].Add(word); // files original word, not the sorted word, into it's group e.g. "eat" & "tea" & "ate" go into the "aet" box
        }

        return result.Values.ToList<List<string>>();
        // gives you the list, ignoring the keys
        // ToList() converts into a List<List<string>>
    }
}
