public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        // index 0 - multiply everything except nums[0]
        // index 1 - multiply everything except nums[1]
        // index 2 - multiply everything except nums[2]
        // ... and so on

        // loop through every element
            // create product = 1
                // loop through every element again
                    // if it is not the current index
                        // multiply into product
                // storre product in result array
                
        int n = nums.Length;

        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            int product = 1;

            for (int j = 0; j < n; j++)
            {
                if (i != j)
                {
                    product *= nums[j];
                }
            }
            result[i] = product;
        }
        return result;

    }
}
