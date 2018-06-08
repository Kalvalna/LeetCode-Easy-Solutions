/*  
    LeetCode Problem #7: Reverse Integer
    Given a 32-bit signed integer, reverse digits of an integer.
    EX 1: 123 -> 321
    EX 2: -123 -> -321
    EX 3: 120 -> 21
    Assume we are dealing with an environment which could only store integers within the 
    32-bit signed integer range. For the purpose of this problem, assume that your 
    function returns 0 when the reversed integer overflows.
*/

class RevInt
{
    // Reverses int by performing modular arithmetic and multiplying by 10 to shift the numbers left
    public static int Reverse(int x)
    {
        // Try-catch blocks to catch an integer overflow
        try
        {
            int result = 0;
            while (x != 0)
            {
                // checked() is used to enable oveflow checking
                result = checked(result * 10 + x % 10);
                x = x / 10;
            }
            return result;
        }
        catch(OverflowException)
        {
            return 0;
        }
    }
}
