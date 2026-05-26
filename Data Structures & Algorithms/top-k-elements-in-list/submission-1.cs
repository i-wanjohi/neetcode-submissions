public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (int num in nums){
            if (count.ContainsKey(num))
                count[num]++;
            else
                count[num] = 1;   
        }

        List<int[]> arr = count.Select(entry => new int[] { entry.Value, entry.Key }).ToList()
;

        arr.Sort((a, b) => b[0].CompareTo(a[0]));

        int[] result = new int[k];

        for (int i=0; i < k; i++)
        {
            result[i] = arr[i][1];
        }

        return result;
    }
}
