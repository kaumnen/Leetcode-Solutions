public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string final1 = "";
        string final2 = "";
        foreach (string x in word1)
        {
            final1 += x;
        }
        foreach (string y in word2)
        {
            final2 += y;
        }
        
        return final1 == final2;
    }
}
