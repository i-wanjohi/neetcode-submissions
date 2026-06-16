public class Solution {
    public string MinWindow(string s, string t) 
    {
        string shortest = "";

        Dictionary<char, int> target = new();

        foreach(char c in t)
        {
            if (target.ContainsKey(c))
            {                target[c]++;
            } else 
            {                target[c] = 1;
            }
        }

        for (int start = 0; start < s.Length; start++)
        {
            for (int end = start; end < s.Length; end++)
            {
                string current = s.Substring(start, (end-start+1));

                if (ContainsAll(current, target))
                {
                    if (shortest == "" || current.Length < shortest.Length)
                    {
                        shortest = current;
                    }
                    break;
                }
            }
        }

        return shortest;   
    }
    public bool ContainsAll(string substring, Dictionary<char, int> target)
    {
        Dictionary<char, int> current = new();

        foreach (char c in substring)
        {
            if (target.ContainsKey(c))
            {
                if (current.ContainsKey(c))
                {
                    current[c]++;
                } else
                {
                    current[c] = 1;
                }
            }
        }
        foreach (var pair in target)
        {
            char character = pair.Key;
            int requiredCount = pair.Value;

            if (!current.ContainsKey(character))
            {
                return false;
            }
            if (current[character] < requiredCount)
            {
                return false;
            }
        }
        return true;
    }
}