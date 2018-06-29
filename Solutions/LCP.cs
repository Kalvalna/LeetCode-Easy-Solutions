/*  
    Write a function to find the longest common prefix string amongst an array of strings.

    If there is no common prefix, return an empty string "".

    Example 1:

    Input: ["flower","flow","flight"]
    Output: "fl"

    Example 2:

    Input: ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.

    Note:

    All given inputs are in lowercase letters a-z.
*/

class LCP
{
    // Naive approach: Comparing all strings letter by letter until difference is found
    public static string NLongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0 || strs == null)
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }

        for(int i = 0; i < strs[0].Length; i++)
        {
            for(int j = 0; j < strs.Length; j++)
            {
                if(strs[j].Length == i)
                {
                    return strs[0].Substring(0, i);
                }
                if (strs[0][i] != strs[j][i])
                {
                    return strs[0].Substring(0, i);
                }
            }
            
        }
        return strs[0];
    }

    // Finds smallest string, creates substring when a difference is found with another
    // of the strings in the list, and continues to do so until the list is exhausted
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0 || strs == null)
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }

        string smallest = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length < smallest.Length)
            {
                smallest = strs[i];
            }
        }

        string solution = smallest;
        for (int i = 0; i < strs.Length; i++)
        {
            for(int j = 0; j < solution.Length; j++)
            {
                if(strs[i][j] != solution[j])
                {
                    solution = solution.Substring(0, j);
                    break;
                }
            }
        }
        return solution;
    }

    // Sorts array alphabetically and compares first string with last string until
    // a difference is found
    public static string SLongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0 || strs == null)
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }

        Array.Sort(strs);
        for(int i = 0; i < strs[0].Length; i++)
        {
            if(strs[strs.Length - 1].Length == i)
            {
                return strs[0].Substring(0, i);
            }
            if(strs[0][i] != strs[strs.Length - 1][i])
            {
                return strs[0].Substring(0, i);
            }
        }
        return strs[0];
    }
}