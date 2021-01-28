public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int result = 0;
        int current = 0;
        
        foreach(int[] i in accounts)
        {
            Array.ForEach(i, x => current += x);
            result = ( current > result ) ? current : result;
            current = 0;
        }
        
        return result;
    }
}