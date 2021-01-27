public class Solution {
    public int LargestAltitude(int[] gain) {
        int result = 0;
        int max = 0;
        foreach(int i in gain)
        {
            result += i;
            if (result > max)
            {
                max = result;
            }
        }
        
        return max;
    }
}