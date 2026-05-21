public class Solution {
    public bool hasDuplicate(int[] nums) {
      // loop through the numbers at 2 indexes
      // if any match is found in numbers at both indexes, bool = true
      // otherwise bool = false

      for (int i = 0; i < nums.Length; i++)
      {
        for (int j = i + 1; j < nums.Length; j++)
        {
          if (nums[i] == nums[j]) { return true; }
        }
      }
      return false; 
    }
}