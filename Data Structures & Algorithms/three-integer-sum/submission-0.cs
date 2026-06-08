public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);

        List<List<int>> result = new();

        HashSet<(int, int, int)> seen = new();
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j< nums.Length; j++)
            {
                for (int k = j+1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        var triplet = (nums[i], nums[j], nums[k]);

                        if (seen.Add(triplet))
                        {
                            result.Add(new List<int>
                            {
                            nums[i], 
                            nums[j], 
                            nums[k]
                            });
                        }

                        
                    }
                }
            }
        }
    return result;
    }
}
