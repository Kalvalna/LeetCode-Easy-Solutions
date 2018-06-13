/*  
    LeetCode Problem #13: Roman to Integer
    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    Symbol       Value
    I             1
    V             5
    X             10
    L             50
    C             100
    D             500
    M             1000

    For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

    Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.

    Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.

    Example 1:

    Input: "III"
    Output: 3

    Example 2:

    Input: "IV"
    Output: 4

    Example 3:

    Input: "IX"
    Output: 9

    Example 4:

    Input: "LVIII"
    Output: 58
    Explanation: C = 100, L = 50, XXX = 30 and III = 3.

    Example 5:

    Input: "MCMXCIV"
    Output: 1994
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
*/

class RomInt
{
    // Sets up dictionary to look up values for roman numerals
    private static Dictionary<Char, int> romToInt = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    // Checks if string is a valid Roman numeral by matching actual with given
    public static bool IsValid(string s, int total)
    {
        string actual = "";
        while(total > 0)
        {
            if (total > 1000)
            {
                actual += 'M';
                total -= 1000;
            }
            else if (total > 900)
            {
                actual += "CM";
                total -= 900;
            }
            else if (total > 500)
            {
                actual += "D";
                total -= 500;
            }
            else if (total > 400)
            {
                actual += "CD";
                total -= 400;
            }
            else if (total > 100)
            {
                actual += "C";
                total -= 100;
            }
            else if (total > 90)
            {
                actual += "XC";
                total -= 90;
            }
            else if (total > 50)
            {
                actual += "L";
                total -= 50;
            }
            else if (total > 40)
            {
                actual += "XL";
                total -= 40;
            }
            else if (total > 10)
            {
                actual += "X";
                total -= 10;
            }
            else if (total > 9)
            {
                actual += "IX";
                total -= 9;
            }
            else if (total > 5)
            {
                actual += "V";
                total -= 5;
            }
            else if (total > 4)
            {
                actual += "IV";
                total -= 4;
            }
            else
            {
                actual += "I";
                total -= 1;
            }
        }
        if (actual == s)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Runs through string by char and finds total value, but evaluates to -1 if invalid roman numeral (EX: IC)
    public static int RomanToInt(string s)
    {
        int total = 0;
        char prev = s[0];
        foreach(char c in s)
        {
            total += romToInt[c];
            if (romToInt[prev] < romToInt[c])
            {
                total -= 2 * romToInt[prev];
            }
            prev = c;
        }
        if (IsValid(s, total))
        {
            return total;
        }
        else
        {
            return -1;
        }
    }
}