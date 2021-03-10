public class Solution {
    public int SumOfUnique(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int result = 0;
        
        foreach(int i in nums)
        {
            if(!dict.ContainsKey(i))
            {
                dict[i] = 1;
            }
            else
            {
                dict[i] += 1;
            }
        }
        
        foreach(KeyValuePair<int, int> entry in dict)
        {
            if (entry.Value == 1)
            {
                result += entry.Key;
            }
        }
        
        return result;
    }
}