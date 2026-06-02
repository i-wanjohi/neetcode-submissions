public class Solution {

    public string Encode(IList<string> strs) 
    {
        StringBuilder encoded = new();

        foreach (string str in strs)
        {
            encoded.Append(str.Length);
            encoded.Append('#');
            encoded.Append(str);
        }  

        return encoded.ToString(); 
        // e.g for the string "Hello, World" - the above code would return 5#Hello5#World
        // 5 - length of string // # - separator // Hello - actual string
    }

    public List<string> Decode(string s) 
    {
        // find #
        // reads number before it
        // uses that number to know how many characters belong to next string
        // jumps to next wagon (section with second separator)
        // repeats until string ends


        List<string> result = new();    // where we will store the decoded strings

        int i = 0;              // think of as index pointer pointing position in encoded string

        while (i < s.Length)            // keep decoding string until we reach the end
        {
            int separatorIndex = i;     // find separator '#' // start searching from current position i.e 0

            while (s[separatorIndex] != '#')    // move until we find the '#'
            {
                separatorIndex++;
            }
            // extract the length part (i = 0 // separatorIndex = 1)
            // s.Substring(0,1) => 5
            // convert to int
            // store as length of word
            int length = int.Parse(s.Substring(i, separatorIndex - i));

            // move to start of string i.e. after the separator
            int stringStart = separatorIndex + 1;

            // extract word
            // s.Substring(2, 5) => start at 2, take the next 5 characters, store them in word
            string word = s.Substring(stringStart, length);

            // add word to result
            result.Add(word);

            // move pointer forward
            // i = 2+5 so i=7
            // while loop starts again
            i = stringStart + length;
        }
        return result;
    }
}

