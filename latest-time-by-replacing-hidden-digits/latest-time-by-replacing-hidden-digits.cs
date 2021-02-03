public class Solution {
    public string MaximumTime(string time) {
        int firstQuest = time.IndexOf('?');
        int secondQuest = time.LastIndexOf('?');
        
        string result = "";
        
        for(int i = 0; i < time.Length; i++)
        {
            if (time[i] == '?')
            {
                if (i == 0)
                {
                    if (time[1] == '?')
                    {
                        result += '2';
                    }
                    else
                    {
                        if (Convert.ToInt32(time[1]) - 48 > 3)
                        {
                            result += '1';
                        }
                        else
                        {
                            result += '2';
                        }
                    }
                }
                else if (i == 1)
                {
                    if (time[0] == '2' || time[0] == '?')
                    {
                        result += '3';
                    }
                    else
                    {
                        result += '9';
                    }
                }
                else if (i == 3)
                {
                    result += '5';
                }
                else
                {
                    result += '9';
                }
            }
            else
            {
                result += time[i];
            }
        }
        
        return result;
    }
}