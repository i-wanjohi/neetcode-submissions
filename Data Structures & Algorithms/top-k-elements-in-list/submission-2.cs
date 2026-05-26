public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        // create dictionary
        // key = number; value = count e.g (2, 5) = 2 appears 5 times
        Dictionary<int, int> count = new Dictionary<int, int>();

        // loop through every number
        foreach (int num in nums){
            if (count.ContainsKey(num)) // if number already exists, increase count by 1
                count[num]++;
            else
                count[num] = 1;   // otheriwse start at 1
        }

        // sort by frequency (highest requency to lowest frequency)
        var sorted = count.OrderByDescending(pair => pair.Value);

        // take the first k numbers
        List<int> result = new List<int> ();

        foreach (var pair in sorted.Take(k))
        {
            result.Add(pair.Key); // add the actual number
        }

        // return as array
        return result.ToArray();
    }
}
