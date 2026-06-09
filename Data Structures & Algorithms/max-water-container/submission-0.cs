public class Solution {
    public int MaxArea(int[] heights) 
    {
        int result = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = i+1; j < heights.Length; j++)
            {
                // area = width * height
                // width =  j - i
                // height = minimum of height between the 2 indexes
                int area = (j - i) * Math.Min(heights[i], heights[j]);
                result = Math.Max(area, result);
            }
        }

        return result;   
    }
}
