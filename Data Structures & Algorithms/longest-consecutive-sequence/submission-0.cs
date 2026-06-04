public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        // check if array is empty
        if (nums.Length == 0) return 0;

        // sort array in increasing order
        Array.Sort(nums);

        // initialise variables to store counts
        int currentStreak = 1;          // store the current count
        int longestStreak = 1;          // store the largest count seen so far

        // loop over elements in the array
        for (int i = 1; i < nums.Length; i++)
        {
            // ignore duplicates
            if (nums[i] == nums[i-1])   // if num at index == the number before it...
            {
                continue;               // ...skip it
            }
            // check for consecutive number
            if (nums[i] == nums[i-1] + 1)   // if num at index == the number before it + 1 (i.e. consecutive)
            {
                currentStreak++;            // add the current streak
            }
            else
            {
                longestStreak = Math.Max(longestStreak, currentStreak);     // when a run ends, submit score to longestStreak
                currentStreak = 1;          // reset streak to 1 if the next number is not consecutive
            }

        }

        return Math.Max(longestStreak, currentStreak);    
    }
}
