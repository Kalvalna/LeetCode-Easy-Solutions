/*  
    LeetCode Problem #1: Two Sum
    Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    EX:
    Given nums = [2, 7, 11, 15], target = 9 
    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0,1]
*/

class TwoSum
{
    // Brute forces TwoSum by using two loops and checking if target - nums[i] = nums[j]
    public static int[] BruteTwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if ((target - nums[i]) == nums[j] && i != j)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }
    // Solves by setting array as dictionary and looking for complement in dictionary
    public static int[] DictTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            dic.Add(nums[i], i);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dic.ContainsKey(complement) && dic[complement] != i)
            {
                return new int[] { i, dic[complement] };
            }
        }
        return null;
    }
}
